using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingService;

namespace ShoppingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService userService;

        public UserController()
        {
            userService = new UserService();
        }

        [Route("GetAllUser")]
        [HttpGet]
        public async Task<IActionResult> GetAllUser()
        {
            var userList = userService.getUsers();

            return Ok(userList);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] string username, string password)
        {
            var userList = userService.getUsers();
            var validUser = userService.ValidateUser(username, password);
            
            return Ok();

        }

    }
}
