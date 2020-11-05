using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService.Contracts
{
    public class UserRoleViewModel
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}
