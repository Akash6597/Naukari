using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Naukari.Domain;
using Naukari.Models;

namespace Naukari.Controllers
{
    [ApiController]
    [Route("[controller]")]
  public class UserController : ControllerBase
    {
        public UserController()
        {
            this.UserDomain = new UserDomain();
        }

        [HttpPost]
        public IActionResult Post(User user)
        {
            var isLoggedIn = this.UserDomain.IsLogin(user);
            return Ok(isLoggedIn);
        }



        private UserDomain UserDomain { get; set; }
    }
}
