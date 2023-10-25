﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Automation_Project.Model;

namespace Test_Automation_Project.Utils
{
    public static class UserBuilder
    {
        private static string validUsername = Environment.GetEnvironmentVariable("test-username");
        private static string validPassword = Environment.GetEnvironmentVariable("test-password");

        public static User ValidUser() => new User(validUsername, validPassword);
        
    }
}
