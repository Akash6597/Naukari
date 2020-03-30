using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class EmployeeLeave
    {
        public int EmployeeLeaveId { get; set; }   

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int EmployeeId { get; set; }
    }
}
