using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


namespace ShoppingService
{
    public class AuthenticateService  :IAuthenticationService
    {
        //private readonly ICustomAuthenticationManager customAuthenticationManager;
       // AuthenticationScheme scheme = new AuthenticationScheme( JwtBearerDefaults.AuthenticationScheme,"",null);
        public async  Task<AuthenticateResult> AuthenticateAsync(HttpContext context, string scheme)
        {
            if (!context.Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Unauthorized");

            string authorizationHeader =context.Request.Headers["Authorization"];
            if (string.IsNullOrEmpty(authorizationHeader))
            {
                return AuthenticateResult.NoResult();
            }
            //if( context.User.FindFirst(c => c.Issuer.f == "http://localhost:5000/"))
           
          
            if (!authorizationHeader.StartsWith("bearer", StringComparison.OrdinalIgnoreCase))
            {
                return AuthenticateResult.Fail("Unauthorized");
            }

            string token = authorizationHeader.Substring("bearer".Length).Trim();

            if (string.IsNullOrEmpty(token))
            {
                return AuthenticateResult.Fail("Unauthorized");
            }
            if (context.User.Claims.SingleOrDefault(c => c.Issuer == "http://localhost:26413/").Value == null)
            {
                return AuthenticateResult.Fail("Unauthorized");
            }
            try
            {
                return validateToken( context);
            }
            catch (Exception ex)
            {
                return AuthenticateResult.Fail(ex.Message);
            }

        }
        public bool ValidateCurrentToken(string token)
        {
            var mySecret = "asdv234234^&%&^%&^hjsdfb2%%%";
            var mySecurityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(mySecret));

            var myIssuer = "http://mysite.com";
            var myAudience = "http://myaudience.com";

            var tokenHandler = new JwtSecurityTokenHandler();
            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = myIssuer,
                    ValidAudience = myAudience,
                    IssuerSigningKey = mySecurityKey
                }, out SecurityToken validatedToken);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private AuthenticateResult validateToken(HttpContext context)
        {
            List<Claim> claims = new List<Claim>();
            foreach (Claim c in context.User.Claims)
            {
                claims.Add(c);
            }
            var identity = new ClaimsIdentity(claims);
            var UserRoleClaim = context.User.Claims.Where(p => p.Type == "Role").FirstOrDefault();

            var principal = new GenericPrincipal(identity, new[] { UserRoleClaim.Value });
            var ticket = new AuthenticationTicket(principal, JwtBearerDefaults.AuthenticationScheme);
            return AuthenticateResult.Success(ticket);
        }


        public Task ChallengeAsync(HttpContext context, string scheme, AuthenticationProperties properties)
        {
            throw new NotImplementedException();
        }

        public Task ForbidAsync(HttpContext context, string scheme, AuthenticationProperties properties)
        {
            throw new NotImplementedException();
        }

        public Task SignInAsync(HttpContext context, string scheme, ClaimsPrincipal principal, AuthenticationProperties properties)
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync(HttpContext context, string scheme, AuthenticationProperties properties)
        {
            throw new NotImplementedException();
        }
    }
}
