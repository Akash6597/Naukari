using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukari.Models
{
    public class Employment
    {
        public int EmploymentDetailId { get; set; }

        public string CompanyName { get; set; }

        public int SalaryLakhs { get; set; }

        public int SalaryThousand { get; set; }
        
        public string Location { get; set; }
        
        public string Skills { get; set; }
        
        public string Industry { get; set; }
        
        public string Area { get; set; }
        
        public string Role { get; set; }

        public int UserId { get; set; }
    }
}
