using Grpc.Core;
using grpcArachne.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace grpcArachne.Services
{
    public class LoginTokenService : LoginToken.LoginTokenBase
    {
        private readonly ILogger<LoginTokenService> _logger;
        private readonly ServerDbContext _db;
        private readonly AppSettings _appSettings;
        public LoginTokenService(ILogger<LoginTokenService> logger, ServerDbContext db, IOptions<AppSettings> appSettings)
        {
            _logger = logger;
            _db = db;
            _appSettings = appSettings.Value;
        }

        public override Task<LoginTokenReturns> GetLoginToken(LoginTokenRequest request, ServerCallContext context)
        {
            var Username = request.UserName;
            var Password = request.UserPassword;
            var user =
                (from T1Supplier in _db.T1SupplierDbSet
                 where T1Supplier.Nama == Username
                 select new
                 {
                     T1Supplier.IdSupplier,
                     T1Supplier.Nama,
                     T1Supplier.IdJenisSupplier,
                     T1Supplier.Alamat
                     
                 }).FirstOrDefault();
            if (user is null)
            {
                Metadata metadata = new Metadata { { "Error", "Username yang anda masukkan salah!" } };
                throw new RpcException(new Status(StatusCode.NotFound, "Not Found"), metadata);
            }

            _logger.LogInformation("User is Loggin in");

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim(ClaimTypes.NameIdentifier, Convert.ToString(user.IdSupplier)),
                        new Claim(ClaimTypes.Name, user.Nama)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            LoginTokenReturns hasil = new LoginTokenReturns();
            if (user != null)
            {
                hasil.Token = tokenHandler.WriteToken(token);
                hasil.IdSupplier = (long)user.IdSupplier;
                hasil.Nama = user.Nama;
                hasil.IdJenisSupplier = (long )user.IdJenisSupplier;
                hasil.Alamat = user.Alamat;
            }
            return Task.FromResult(hasil);
        }
    }
}
