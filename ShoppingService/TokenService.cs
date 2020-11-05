using Microsoft.Extensions.Options;
using ShoppingCartEntities;
using ShoppingService.Contracts;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;

namespace ShoppingService
{
    public class TokenService : ITokenService
    {
        IConfiguration conf;
        string _secret;
        AppSettings settings;
        public TokenService(IOptions<AppSettings> appsettings )
        {
            settings = appsettings.Value; 
        }
        //public TokenService( IConfiguration Configuration)
        //{
        //    conf = Configuration;
        //}
        public string Create(ApplicationUser applicationUser, string secret)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            IDictionary<string, Object> claimsholder = new Dictionary<string, Object>();

            var roleClaims = new List<Claim>();
            roleClaims.Add(new Claim("UserId", applicationUser.Id.ToString()));
            roleClaims.Add(new Claim("UserName", applicationUser.UserName));

            foreach (UserRole userRole in applicationUser.Roles)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, userRole.RoleName));
            }

            
            var token = new JwtSecurityToken(
                    claims: roleClaims,
                    issuer: "http://localhost:26413/",
                    expires: DateTime.UtcNow.AddDays(7),
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            );

            return (new JwtSecurityTokenHandler().WriteToken(token)).ToString();
        }
    }
}
