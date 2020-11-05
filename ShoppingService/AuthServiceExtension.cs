using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ShoppingCartEntities;
using ShoppingService;
using ShoppingService.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingService
{
    public static class AuthServiceExtension
    {
        public static IServiceCollection AddAuthServices(this IServiceCollection services, IOptions<AppSettings> appSettings)
        {
            services.AddTransient<ITokenService>(e => new TokenService(appSettings));

            return services;
        }
    }
}
