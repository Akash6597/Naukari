using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukari.Models
{
    public class User
    {
        //public int UserId { get; set; }

        public string Name { get; set; }

        public string EmailId { get; set; }

        public string Password { get; set; }

        public string MobileNumber { get; set; }

        public string Location { get; set; }

        public bool Privacy { get; set; }

        public int ExperienceYear { get; set; }

        public int ExperienceMonth { get; set; }
    }
}
