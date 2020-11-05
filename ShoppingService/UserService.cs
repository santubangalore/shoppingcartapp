using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using System.Linq;
using ShoppingCartEntities ;
using Datamodel=DataLayer.Model;
using ShoppingService.Contracts;
using System.Security.Claims;

namespace ShoppingService
{

    public  class UserService :IUserService
    {
        private Datamodel.ECommerceContext commerceContext = new Datamodel.ECommerceContext();


        public ApplicationUser GetUserDetail(string userName, string password)
        {
            var dbUser = commerceContext.Users.Where(p => p.UserName == userName && p.PassWord == password && p.IsActive).SingleOrDefault();
            //return User == null ? false : true;
            if (dbUser != null)
            {
                ApplicationUser user = new ApplicationUser
                {
                    Id = dbUser.Id,
                    UserName = dbUser.UserName,
                    //PassWord = dbUser.PassWord,
                    //IsActive = dbUser.IsActive,
                    //CreatedDate = dbUser.CreatedDate,
                    //Roles = dbUser.Roles
                };
                return user;
            }
            else
                return default;
        }

        public ApplicationUser ValidateUser(string username, string password)
        {
            ApplicationUser user = new ApplicationUser();
            var User = commerceContext.Users.Where(p => p.UserName == username && p.PassWord == password && p.IsActive).SingleOrDefault();
            //= null ? false : true;
            if (User == null)
                return null;

            if (User != null) {

                var query = commerceContext.Users.Where(p => p.UserName == username && p.PassWord == password && p.IsActive)
                    .Join(commerceContext.UserRoles, r => r.Id, p => p.UserId, (r, p) => new {p.UserId, r.UserName, r.Id, p.RoleId })
                    .Join(commerceContext.Roles,a=> a.RoleId, b=> b.Id, (a, b) => new UserRoleViewModel {UserId=a.UserId, RoleId = a.RoleId, UserName= a.UserName,RoleName= b.RoleName }).ToList();

                List<Claim> claimsList = new List<Claim>();
                user.NormalizedUserName = username;
                user.UserName = username;
                int UserID = 0;                
                List<UserRole> roles = new List<UserRole>();
                query.ForEach((obj) =>
                {
                    UserID = obj.UserId;
                    UserRole role = new UserRole();
                    role.RoleId = obj.RoleId;
                    role.RoleName = obj.RoleName;
                    Claim claim = new Claim("Role", obj.RoleName);
                    claimsList.Add(claim);
                    roles.Add(role);
                });
                user.Claims = claimsList;
                user.Roles = roles;
                user.Id = UserID;
            }
            return user;
        }

        public List<ApplicationUser> getUsers()
        {
            List<ApplicationUser> ValidUserList = new List<ApplicationUser>();
            var userList=commerceContext.Users.Where(p => p.IsActive).AsQueryable();
            foreach(Datamodel.Users u in userList)
            {
                ValidUserList.Add(new ApplicationUser
                {
                    Id = u.Id,
                    UserName = u.UserName,
                    PasswordHash = u.PassWord,
                 
                });
            }
            return ValidUserList;
        }
    }
}
