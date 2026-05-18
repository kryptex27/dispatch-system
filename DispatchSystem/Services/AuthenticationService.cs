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

        private bool choosedRole = false;

        private bool isLoggedIn = false;

        private bool isRegistered = false;

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

        public int GetCurrentUserRole()
        {
            if (currentUser != null)
            {
                return currentUser.Role;
            }
            return 0;
        }

        public bool ChoosedRole()
        {
            return choosedRole;
        }

        public void Logout()
        {
            isLoggedIn = false;
            currentUser = null;
        }

        public bool Register(string userName, string password)
        {
            User newUser;
            newUser = new Unregistered();

            currentUser = null;

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
                currentUser = newUser;
                isRegistered = true;

            }
            return isRegistered;
        }
        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }

        public bool IsRegistered()
        {
            return users.Count > 0;
        }


        public int ChooseRole(int roleChoice)
        {
            if (currentUser.Role == 0)
            {
                if (roleChoice == 1) SetUserProperties(new Dispatcher(), 1);
                else if (roleChoice == 2) SetUserProperties(new Hr(), 2);
                else if (roleChoice == 3) SetUserProperties(new Operation(), 3);
                else if (roleChoice == 4) SetUserProperties(new Admin(), 4);
            }
            return currentUser.Role;
        }

        private void SetUserProperties(User newUser, int role)
        {
            newUser.UserName = currentUser.UserName;
            newUser.Password = currentUser.Password;
            newUser.Id = currentUser.Id;
            newUser.Role = role;
            users.Remove(currentUser);
            users.Add(newUser);
            currentUser = newUser;
        }

        public User GetCurrentUser()
        {
            return currentUser;
        }
    }
}


