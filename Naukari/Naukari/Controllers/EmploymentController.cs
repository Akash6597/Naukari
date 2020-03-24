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
    public class EmploymentController:ControllerBase
    {
        public EmploymentController()
        {
            this.EmploymentDomain = new EmploymentDomain();
        }
        [HttpPost]
        public IActionResult Post(Employment employment)
        {
            this.EmploymentDomain.Add(employment);
            return Ok();
        }


        private EmploymentDomain EmploymentDomain { get; set; }
    }
}

