using bzrArachnePWA.Client.Models;
using bzrArachnePWA.Server.Data;
using bzrArachnePWA.Server.Hubs;
using bzrArachnePWA.Server.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Text;

namespace bzrArachnePWA.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
            services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
            }));
            services.AddControllersWithViews();
            services.AddRazorPages();

            //Add Database Connection
            services.AddDbContext<ServerDbContext>(option =>
                option.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //JWT Bearer Auth
            var appSettingSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingSection);

            var appSettings = appSettingSection.Get<AppSettings>();
            var key = Encoding.UTF8.GetBytes(appSettings.Secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            services.AddAuthorization();
            services.AddSignalR();
            services.AddResponseCompression(opts =>
            {
                opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
                    new[] { "application/octet-stream" });
            });


        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseGrpcWeb();
            app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<BarangService>().EnableGrpcWeb().RequireCors("AllowAll");
                endpoints.MapGrpcService<LoginTokenService>().EnableGrpcWeb().RequireCors("AllowAll");
                endpoints.MapGrpcService<CryptoService>().EnableGrpcWeb().RequireCors("AllowAll");
                endpoints.MapGrpcService<PenawaranPembelianService>().EnableGrpcWeb().RequireCors("AllowAll");
                endpoints.MapGrpcService<AtributFormService>().EnableGrpcWeb().RequireCors("AllowAll");
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapHub<BroadcastHub>("/broadcastHub");
                endpoints.MapHub<ChatHub>("/chatHub");
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
