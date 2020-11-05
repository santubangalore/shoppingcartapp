using ShoppingCartEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService.Contracts
{
   public interface ITokenService
    {
        string Create(ApplicationUser user, string secret);

    }
}
