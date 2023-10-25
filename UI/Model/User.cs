using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Automation_Project.Model
{
    public class User
    {
        private string email;
        private string password;

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public string GetUsername() => this.email;

        public string GetPassword() => this.password;
    }
}
