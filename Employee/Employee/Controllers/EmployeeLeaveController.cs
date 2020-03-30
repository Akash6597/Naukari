using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee.Domain;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Employee.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeLeaveController : ControllerBase
    { 
        public EmployeeLeaveController()
        {
            this.EmployeeLeaveDomain = new EmployeeLeaveDomain();
        }
        [HttpGet]
        public IActionResult GetEmp()
        {
            var employeeleave = this.EmployeeLeaveDomain.GetEmp();
            return Ok(employeeleave);
        }
        [HttpPost]
        public IActionResult AddLeave(EmployeeLeave employeeLeave)
        {
            this.EmployeeLeaveDomain.AddLeave(employeeLeave);
            return Ok();
        }
        private EmployeeLeaveDomain EmployeeLeaveDomain { get; set; }
    }
}
