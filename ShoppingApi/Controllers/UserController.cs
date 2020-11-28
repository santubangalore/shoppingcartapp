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

        [HttpPost("Test")]
        public async Task<IActionResult> Authenticate()
        {
            var userList = userService.getUsers();
            List<string> townlist= new List<string>();
            for (int i=0;i<10;i++)
            {
                townlist.Add("Town"+i.ToString());
            }
            return Ok(townlist);


        }

    }
}
