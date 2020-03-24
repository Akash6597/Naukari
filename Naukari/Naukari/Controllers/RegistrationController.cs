using Microsoft.AspNetCore.Mvc;
using Naukari.Domain;
using Naukari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukari.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController: ControllerBase
    {
        public RegistrationController()
        {
            this.UserDomain = new UserDomain();
        }
        [HttpPost]
        public IActionResult PostUser(User user)
        {
            this.UserDomain.Registration(user);
            return Ok();
        }
        private UserDomain UserDomain { get; set; }
    }
}
