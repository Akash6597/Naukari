using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukari.Models
{
    public class Education
    {
        public int EducationDetailId { get; set; }

        public string Qualification { get; set; }

        public  string Course { get; set; }

        public string Specialization { get; set; }

        public string College { get; set; }

        public int PassingYear { get; set; }

        public string Skills { get; set; }

        public int UserId { get; set; }
    }
}

