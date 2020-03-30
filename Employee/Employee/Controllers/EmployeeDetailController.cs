using Employee.Domain;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeDetailController:ControllerBase
    {
        public EmployeeDetailController()
        {
            this.EmployeeDetailDomain = new EmployeeDetailDomain();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var employeedetail = this.EmployeeDetailDomain.Get();
            return Ok(employeedetail);
        }
        [HttpPost]
        public IActionResult AddEmp(EmployeeDetail employeedetail)
        {
            this.EmployeeDetailDomain.AddEmp(employeedetail);
            return Ok();
        }
        private EmployeeDetailDomain EmployeeDetailDomain { get; set; }
    }
}
