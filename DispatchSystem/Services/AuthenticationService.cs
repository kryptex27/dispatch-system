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
            return isRegistered;
        }   


        public int ChooseRole(int roleChoice)
        {
            if (currentUser.Role == 0)
            {
                currentUser.Role = roleChoice;

                if (currentUser.Role == 1)
                {
                    User dispatcherUser = new Dispatcher();
                    {
                        dispatcherUser.UserName = currentUser.UserName;
                        dispatcherUser.Password = currentUser.Password;
                        dispatcherUser.Id = currentUser.Id;
                        dispatcherUser.Role = 1;

                        users.Remove(currentUser);
                        users.Add(dispatcherUser);

                        currentUser = dispatcherUser;
                    }

                }

                if (currentUser.Role == 2)
                {
                    User hrUser = new Hr();
                    {
                        hrUser.UserName = currentUser.UserName;
                        hrUser.Password = currentUser.Password;
                        hrUser.Id = currentUser.Id;
                        hrUser.Role = 2;

                        users.Remove(currentUser);
                        users.Add(hrUser);
                        currentUser = hrUser;
                    }

                }

                if (currentUser.Role == 3)
                {
                    User operationUser = new Operation();
                    {
                        operationUser.UserName = currentUser.UserName;
                        operationUser.Password = currentUser.Password;
                        operationUser.Id = currentUser.Id;
                        operationUser.Role = 3;

                        users.Remove(currentUser);
                        users.Add(operationUser);
                        currentUser = operationUser;
                    }
                }

                if (currentUser.Role == 4)
                {
                    User adminUser = new Admin();
                    {
                        adminUser.UserName = currentUser.UserName;
                        adminUser.Password = currentUser.Password;
                        adminUser.Id = currentUser.Id;
                        adminUser.Role = 4;
                        users.Remove(currentUser);
                        users.Add(adminUser);
                        currentUser = adminUser;
                    }
                }
            }
            return currentUser.Role;
        }
    }
}


