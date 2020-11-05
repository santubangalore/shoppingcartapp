using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication
{
    public class BasicAuthenticationPostConfigureOptions: IPostConfigureOptions<BasicAuthenticationOptions>
    {
        public BasicAuthenticationPostConfigureOptions()
        {

        }

        public void PostConfigure(string name, BasicAuthenticationOptions options)
        {
            if (string.IsNullOrEmpty(options.Realm))
            {
                throw new InvalidOperationException("Realm must be provided in options");
            }
        }
    }
}
