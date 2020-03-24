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
    public class EducationController: ControllerBase
    {

        public EducationController()
        {
            this.EducationDomain = new EducationDomain();
        }
        [HttpPost]
        public IActionResult Post(Education education)
        {
            this.EducationDomain.Add(education);
            return Ok(); 
        }


        private EducationDomain EducationDomain { get; set; }
    }
}
