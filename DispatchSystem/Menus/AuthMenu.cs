using DispatchSystem.Models;
using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text;

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
                        if (auth.IsLoggedIn())
                            HandleLogOut();
                        else
                            Console.WriteLine("Invalid choice.");
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

    if (!auth.IsLoggedIn())
    {
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Login");
    }
    else
    {
        Console.WriteLine("3. Logout");
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
            string userName= Console.ReadLine();

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
    }
}



