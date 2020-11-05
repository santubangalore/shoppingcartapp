using System;
using System.Collections.Generic;

namespace DataLayer.Model
{
    public partial class Login
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? LoginDate { get; set; }
        public bool? Success { get; set; }

        public virtual Users User { get; set; }
    }
}
