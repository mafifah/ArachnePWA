using Blazored.Toast;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace bzrArachnePWA.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddMudServices();
            builder.Services.AddBlazoredToast();
            builder.Services.AddSweetAlert2();
            builder.Services.AddSingleton<Service.DataService>();
            builder.Services.AddSingleton<Service.FormAtributService>();
            builder.Services.AddSingleton<Service.PenawaranService>();
            await builder.Build().RunAsync();
        }
    }
}
