using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Menus
{
    internal class HrMenu
    {
        HrService hrService;

        public HrMenu(HrService hrService)
        {
            this.hrService = hrService;
        }

        public void ShowHrMenu()
        {
            while(true)
            {
                Console.WriteLine("HR Menu:");
                Console.WriteLine("1. Create Driver");
                Console.WriteLine("2. Show All Drivers");
                Console.WriteLine("3. Delete Driver");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        hrService.CreateDriver();
                        break;
                    case "2":
                        hrService.ShowAllDrivers();
                        break;
                    case "3":
                        hrService.DeleteDriver();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
