using ShoppingCartEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService.Contracts
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(LoginRequest request, out string token);
    }
}
