using ShoppingCartEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService.Contracts
{
    public interface IUserService
    {
        ApplicationUser GetUserDetail(string userName, string password);
        ApplicationUser ValidateUser(string username, string password);
        List<ApplicationUser> getUsers();

    }
}
