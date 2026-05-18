using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Menus
{
    internal class AdminMenu
    {
        DriverMenu driverMenu;
        LoadMenu loadMenu;
        OperationMenu operationMenu;
        DispatcherMenu dispatcherMenu;
        HrMenu hrMenu;

        public AdminMenu(DriverMenu driverMenu, LoadMenu loadMenu, OperationMenu operationMenu, DispatcherMenu dispatcherMenu, HrMenu hrMenu)
        {
            this.driverMenu = driverMenu;
            this.loadMenu = loadMenu;
            this.operationMenu = operationMenu;
            this.dispatcherMenu = dispatcherMenu;
            this.hrMenu = hrMenu;
        }

        public void ShowAdminMenu()
        {
            while (true)
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Dispatcher");
                Console.WriteLine("2. Operation");
                Console.WriteLine("3. HR Management");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    dispatcherMenu.ShowDispatcherMenu();
                }
                else if (choice == "2")
                {
                    operationMenu.ShowOperationMenu();
                }
                else if (choice == "3")
                {
                    hrMenu.ShowHrMenu();
                }
                else if (choice == "4")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

            }

        }
    }
}