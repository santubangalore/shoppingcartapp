using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace ShoppingCartEntities
{
    public class UserRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<Claim> Claims { get; set; }
    }
}
