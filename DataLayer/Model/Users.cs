using System;
using System.Collections.Generic;

namespace DataLayer.Model
{
    public partial class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool IsActive { get; set; }
        public string Roles { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
