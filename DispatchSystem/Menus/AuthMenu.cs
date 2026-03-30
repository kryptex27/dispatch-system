using DispatchSystem.Models;
using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Channels;

namespace DispatchSystem.Menus
{
    public class AuthMenu

    {
        AuthenticationService auth = new AuthenticationService();
        public void Start()
        {

            while (true)
            {
                ShowMenu();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HandleRegister();
                        break;
                    case "2":
                        HandleLogin();
                        break;
                    case "3":
                        HandleChooseRole();
                        break;
                    case "4":
                        HandleLogOut();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("\n=== Authentication Menu ===");

            if (!auth.IsRegistered())
            {
                Console.WriteLine("1. Register");
            }

            else if (auth.IsRegistered() && auth.GetCurrentUserRole() == 0)
            {
                Console.WriteLine("3. Choose Role");
            }

            else if (!auth.IsLoggedIn())
            {
                Console.WriteLine("2. Login");
            }

            else if (auth.IsLoggedIn())
            {
                Console.WriteLine("4. Logout");
            }
        }
        private void HandleLogin()
        {
            Console.WriteLine("Please enter UserName: ");
            string userName = Console.ReadLine();
            userName = userName.Trim();

            Console.WriteLine("Please enter Password: ");
            string password = Console.ReadLine();
            password = password.Trim();


            bool result = auth.Login(userName, password);

            if (result == true)
            {
                Console.WriteLine("Login successful!");

            }
            else if (result == false)
            {
                Console.WriteLine("Login failed! Please check your username and password.");
            }

        }

        private void HandleRegister()
        {
            Console.WriteLine("Please enter UserName: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Please enter Password: ");
            string password = Console.ReadLine();


            bool result = auth.Register(userName, password);

            if (result == true)
            {
                Console.WriteLine("Registration successful!");
            }

            else if (result == false)
            {
                Console.WriteLine("Registration failed! Please check your username and password.");
            }

        }
        private void HandleLogOut()
        {
            string name = auth.GetCurrentUserName();
            auth.Logout();
            Console.WriteLine($"Good bye {name} ");
        }

        private void HandleChooseRole()
        {
            Console.WriteLine("Please enter your Role:");
            Console.WriteLine("1. Dispatcher");
            Console.WriteLine("2. HR");
            Console.WriteLine("3. Operation");
            Console.WriteLine("4. Admin");

            int roleChoice = Convert.ToInt32(Console.ReadLine());

            roleChoice = auth.ChooseRole(roleChoice);


            if (roleChoice == 1)
            {
                auth.ChooseRole(roleChoice);
                Console.WriteLine("You have chosen Dispatcher role.");
            }
            else if (roleChoice == 2)
            {
                auth.ChooseRole(roleChoice);
                Console.WriteLine("You have chosen HR role.");
            }
            else if (roleChoice == 3)
            {
                auth.ChooseRole(roleChoice);
                Console.WriteLine("You have chosen Operation role.");
            }
            else if (roleChoice == 4)
            {
                auth.ChooseRole(roleChoice);
                Console.WriteLine("You have chosen Admin role.");
            }
            else
            {
                Console.WriteLine("Invalid role choice. Please try again.");
            }
        }

    }
}



