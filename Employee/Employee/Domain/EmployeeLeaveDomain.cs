using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Domain
{
    public class EmployeeLeaveDomain:BaseDomain
    {
        public List<EmployeeLeave> GetEmp()
        {
            var reader = this.GetReader("select * from EmployeeLeaves");
            var employeeleaves = new List<EmployeeLeave>();
            while (reader.Read())
            {
                var employeeleave = new EmployeeLeave();
                employeeleave.FromDate = reader.GetDateTime(1);
                employeeleave.ToDate = reader.GetDateTime(2);
                employeeleave.EmployeeId = reader.GetInt32(0);
                employeeleaves.Add(employeeleave);
            }
            return employeeleaves;
        }
        public void AddLeave(EmployeeLeave employeeLeave)
        {
            this.ExecuteNonQuery($"insert into EmployeeLeaves (FromDate,ToDate,EmployeeId) values('{employeeLeave.FromDate}','{employeeLeave.ToDate}','{employeeLeave.EmployeeId}')");
        }
    }
}
