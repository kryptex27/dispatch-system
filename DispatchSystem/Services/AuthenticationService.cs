using DispatchSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{
    public class AuthenticationService
    {
        private List<User> users = new List<User>();

        private bool isLoggedIn = false;
        public bool Login(string Username, string Password)
        {

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                isLoggedIn = false;
            }
            foreach (User newUser in users)
            {
                if (newUser.UserName == Username && newUser.Password == Password)
                {
                     isLoggedIn = true;
                }
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
            User newUser = new User();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                isRegistered = false;
            }
            else 
            {
               
                newUser.UserName = userName;
                newUser.Password = password;

                users.Add(newUser);

                isRegistered = true;
            }
            return isRegistered;

        }
    }
}
