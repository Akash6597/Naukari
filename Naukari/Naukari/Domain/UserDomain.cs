using Naukari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace Naukari.Domain
{
    public class UserDomain:BaseDomain
    {
        public bool IsLogin(User user)
        {
            var reader = this.GetReader($"select * from users where emailid = '{user.EmailId}' and password = '{user.Password}'");
            var isLoggedIn = false;
            while (reader.Read())
            {
                isLoggedIn = true;
            }
            return isLoggedIn;
        }
        public void Registration(User user)
        {
            this.ExecuteNonQuery($"insert into users (Name,EmailId,Password,MobileNumber,Location,Privacy,ExperienceYear,ExperienceMonth) values('{user.Name}','{user.EmailId}','{user.Password}','{user.MobileNumber}','{user.Location}','{user.Privacy}',{user.ExperienceYear},{user.ExperienceMonth})");
        }

    }

}

