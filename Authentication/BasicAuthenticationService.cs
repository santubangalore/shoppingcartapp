using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{
    public class BasicAuthenticationService : IBasicAuthenticationService
    {
        public async Task<bool> IsValidUserAsync(string user, string password)
        {
            return true;
        }
    }
}
