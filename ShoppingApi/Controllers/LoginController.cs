using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ShoppingApi.ViewModels;
using ShoppingService.Contracts;

namespace ShoppingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserService _iUserService;
        private ITokenService _tokenService;
        private IConfiguration conf;
        public LoginController(IUserService userService, ITokenService tokenService, IConfiguration configuration)
        {
            _iUserService = userService;
            _tokenService = tokenService;
            conf = configuration;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginViewModel model)
        {
            var result = _iUserService.ValidateUser(model.username, model.password);
            string token = string.Empty;
            if (result == null)
            {
                return BadRequest();
            }
            var section = conf.GetSection("AppSettings");
            string secret=section.GetSection("Secret").Value;
            token= _tokenService.Create(result, secret);
            UserViewModel _user = new UserViewModel();
            _user.Id = result.Id;
            _user.JwtToken = token;
            _user.UserName = model.username;
            //_user.Id
            return Ok(_user);
        }
    }


}
