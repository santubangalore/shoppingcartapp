using ShoppingCartEntities;
using ShoppingService.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public class TokenAuthenticationService : IAuthenticateService
    {
        public bool IsAuthenticated(LoginRequest request, out string token)
        {
            throw new System.NotImplementedException();
        }
    }
}
