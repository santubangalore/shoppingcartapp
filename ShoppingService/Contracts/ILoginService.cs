using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService.Contracts
{
    interface ILoginService
    {
        string ValidateUser(string user, string password);
        string Login(string User, string password);

    }
}
