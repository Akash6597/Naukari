using Naukari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukari.Domain
{
    public class EducationDomain:BaseDomain
    {

        public void Add(Education education)
        {
            this.ExecuteNonQuery($"insert into Educations (Qualification,Course,Specialization,College,PassingYear,Skills,UserId) values('{education.Qualification}','{education.Course}','{education.Specialization}','{education.College}','{education.PassingYear}','{education.Skills}','{education.UserId}')");
        }
    }
}

