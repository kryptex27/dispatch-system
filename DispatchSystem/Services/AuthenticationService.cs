using DispatchSystem.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DispatchSystem.Services
{
    public class AuthenticationService
    {

        private List<User> users = new List<User>();

        private bool isLoggedIn = false;

        private User currentUser;
        public bool Login(string Username, string Password)
        {
            isLoggedIn = false;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                isLoggedIn = false;
            }
            foreach (User newUser in users)
            {
                if (newUser.UserName == Username && newUser.Password == Password)
                {
                    isLoggedIn = true;
                    currentUser = newUser;
                }
            }
            return isLoggedIn;

        }
        public string GetCurrentUserName()
        {
            return currentUser.UserName;
        }
        public void Logout()
        {
            isLoggedIn = false;
        }

        private bool isRegistered = false;
        public bool Register(string userName, string password)
        {

            User newUser;
            newUser = new Dispatcher();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                isRegistered = false;
            }
            else if (userName.Length < 3 || password.Length < 3)
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
        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }
        public int ChooseRole(int roleChoice)
        {
            foreach (User user in users)
            {
                user.Role = roleChoice;
            }
            return roleChoice;
        }
    }
}
