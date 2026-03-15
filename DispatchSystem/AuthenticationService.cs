using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem
{
    public class AuthenticationService
    {
        private User user = new User();

       private bool isLoggedIn = false;
        private string Login()
        {
            while (true)
            {
                Console.WriteLine("UserName: ");
                string enteredUserName = Console.ReadLine();

                if (string.IsNullOrEmpty(enteredUserName))
                {
                    Console.WriteLine("Username cannot be empty.");
                    continue;
                }

                Console.WriteLine("Password: ");
                string enteredPassword = Console.ReadLine();

                if (string.IsNullOrEmpty(enteredPassword))
                {
                    Console.WriteLine("Password cannot be empty.");
                    continue;
                }

                if (enteredUserName == user.UserName && enteredPassword == user.Password)
                {
                    isLoggedIn = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid username or password. Please try again.");
                }
            }
            return "Login successful!";

        }
        private string Logout()
        {
            isLoggedIn = false;
            return "Logout successful!";
        }

        public void StartSession()
        {

            while (true)
            {
                Console.WriteLine("Please enter number for action: ");

                Console.WriteLine("1. Register\n2. Login");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine(Register());

                }
                if (choice == 2)
                {
                    Console.WriteLine(Login());

                }

                if(isLoggedIn == true)
                {
                    break;
                }

            }

        }


        private string Register()
        {
            while(true)
            {
                Console.WriteLine("Please enter UserName: ");
                user.UserName = Console.ReadLine();

                if (string.IsNullOrEmpty(user.UserName))
                {
                    Console.WriteLine("Username cannot be empty.");
                    continue;
                }

                Console.WriteLine("Please enter Password");
                user.Password = Console.ReadLine();

                if (string.IsNullOrEmpty(user.Password))
                {
                    Console.WriteLine("Password cannot be empty.");
                    continue;
                }

                return "Registration successful!";

            }
        }

   
    }
}
