using Naukari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naukari.Domain
{
    public class EmploymentDomain:BaseDomain
    {
        public void Add(Employment employment)
        {
            this.ExecuteNonQuery($"insert into Employments (CompanyName,SalaryLakhs,SalaryThousand,Location,Skills,Industry,Area,Role,UserId) values('{employment.CompanyName}',{employment.SalaryLakhs},{employment.SalaryThousand},'{employment.Location}','{employment.Skills}','{employment.Industry}','{employment.Area}','{employment.Role}',{employment.UserId})");
        }
    }
}
