using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Domain
{
    public class EmployeeDetailDomain:BaseDomain
    {
        public List<EmployeeDetail> Get()
        {
            var reader = this.GetReader("select * from Employees");
            var employeedetails = new List<EmployeeDetail>();
            while (reader.Read())
            {
                var employeedetail = new EmployeeDetail();
                employeedetail.EmployeeId = reader.GetInt32(0);
                employeedetail.EmployeeName = reader.GetString(1);
                employeedetails.Add(employeedetail);
            }
            return employeedetails;
        }
        public void AddEmp(EmployeeDetail employeeDetail)
        {
            this.ExecuteNonQuery($"insert into EmployeeDetails (EmployeeName) values('{employeeDetail.EmployeeName}')");
        }
    }
}
