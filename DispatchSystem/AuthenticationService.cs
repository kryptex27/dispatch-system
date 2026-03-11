using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem
{
    public class AuthenticationService
    {
        User user = new User();
        private string Login()
        {

            Console.WriteLine("UserName: ");
            string enteredUserName = Console.ReadLine();

            Console.WriteLine("Password: ");
            string enteredPassword = Console.ReadLine();

            if (enteredUserName == user.UserName && enteredPassword == user.Password)
            {
                return "Login successful!";
            }
            else
            {
                return "Invalid username or password.";
            }

        }
        private string Logout()
        {
            return "Logout successful!";
        }

        public void StartSession()
        {
            Console.WriteLine("Welcome to dispatch system!");
            Console.WriteLine(Register());
            Console.WriteLine(Login());
        }

        private string Register()
        {
            Console.WriteLine("Please enter UserName: ");
            user.UserName = Console.ReadLine();
            Console.WriteLine("Please enter Password");
            user.Password = Console.ReadLine();

            return "Registration successful!";

        }

    }
}
