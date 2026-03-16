using DispatchSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{
    public class AuthenticationService
    {
        private User user = new User();

        private bool isLoggedIn = false;
        public bool Login(string Username, string Password)
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                isLoggedIn = false;
            }

            else if (Username == user.UserName && Password == user.Password)
            {
                isLoggedIn = true;
            }
            return isLoggedIn;

        }
        public string Logout()
        {
            isLoggedIn = false;
            return "Logout successful!";
        }

       private bool isRegistered = false;  
        public bool Register(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                isLoggedIn = false;
            }
            else 
            {
                user.UserName = userName;
                user.Password = password;
                isRegistered = true;
            }
            return isRegistered;

        }
    }
}
