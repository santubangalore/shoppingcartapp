using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using DataLayer.Model;
using AdventureworksContext.Model;
using Microsoft.AspNetCore.Cors.Infrastructure;
using AdverntureWorksService.Contract;
using AdverntureWorksService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using ShoppingCartEntities;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Authentication;
using Microsoft.Extensions.Options;
//using ShoppingApi.Extensions;
using ShoppingService.Contracts;
using Microsoft.AspNetCore.Authentication;

using ShoppingService;

namespace ShoppingApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string ShoppingCartConn = Configuration.GetSection("ConnectionStrings").GetSection("ShoppingCartConn").Value.ToString();
            services.AddDbContext<ECommerceContext>((options) =>
            {
                options.UseSqlServer(ShoppingCartConn);
            });

            string AdventureWorksConn = Configuration.GetSection("ConnectionStrings").GetSection("AdventureWorksConn").Value.ToString();
            services.AddDbContext<AdventureWorksDbContext>((options) =>
            {
                options.UseSqlServer(AdventureWorksConn);
            });

            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                                     .AllowAnyMethod()
                                                                      .AllowAnyHeader()));
            var appSettingsSection = Configuration.GetSection("AppSettings");
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer
             (x =>
             {
                 x.RequireHttpsMetadata = false;
                 x.SaveToken = true;
                 x.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuerSigningKey = true,
                     IssuerSigningKey = new SymmetricSecurityKey(key),
                     ValidateIssuer = true,
                     ValidateAudience = false,
                     ValidIssuer= "http://localhost:26413/"

                 };
             });

            services.AddAuthorization(options =>
            {
                options.DefaultPolicy =
                    new AuthorizationPolicyBuilder(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build();
            });

            /*
            services.AddAuthorization(options =>
            {
                options.AddPolicy("OfficeNumberUnder200", policy => policy.Requirements.Add(new MaximumOfficeNumberRequirement(200)));
            });
            */

            services.Configure<AppSettings>(Configuration);
            services.AddOptions();
            services.AddScoped<IUserService, UserService>();
            services.AddAuthentication();
            services.AddScoped<ITokenService, TokenService>();

            //services.AddSingleton<IAuthorizationPolicyProvider, AuthorizationPolicyProvider>();
            services.AddSingleton<IAuthorizationHandler, PermissionHandler>();
            //services.AddSingleton<IAuthenticationService, AuthenticateService>();
            // services.AddScoped<IAuthenticateService, TokenAuthenticationService>();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = false;
                options.ExpireTimeSpan = TimeSpan.FromDays(7);
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/log-off";
                options.AccessDeniedPath = "/account/login";
                options.SlidingExpiration = true;
            });

            services.AddScoped<IProductCategoriesInterface, ProductCategoriesService>();
            services.AddScoped<IProductInterface, ProductService>();

            services.AddAuthServices(services.BuildServiceProvider().GetService<IOptions<AppSettings>>());
            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseMiddleware<myMiddleWare>();
            app.UseCors("AllowAll");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
