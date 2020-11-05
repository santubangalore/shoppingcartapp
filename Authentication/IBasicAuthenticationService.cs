using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public interface IBasicAuthenticationService
    {
        Task<bool> IsValidUserAsync(string user, string password);
    }
}
