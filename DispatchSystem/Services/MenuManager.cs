using DispatchSystem.Interfaces;
using DispatchSystem.Menus;
using DispatchSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{
    public class MenuManager
    {
        DriverService driverService = new DriverService();
        DriverMenu driverMenu;
        DispatcherMenu dispatcherMenu;

        public User currentUser;
        int choosedAction;

        public MenuManager()
        {
            driverMenu = new DriverMenu(driverService);
            dispatcherMenu = new DispatcherMenu(driverService);
        }


        public void ShowMenu()
        {
            if (currentUser.Role == 2)
            {
                Console.WriteLine("1. Add Driver");
                Console.WriteLine("2. Show All Drivers");
                Console.WriteLine("3. Delete Driver");

                choosedAction = Convert.ToInt32(Console.ReadLine());

                if (choosedAction == 1)
                {
                    driverMenu.AddingDriver();
                }
                else if (choosedAction == 2)
                {
                    driverMenu.ShowDrivers();
                }
                else if (choosedAction == 3)
                {
                    driverMenu.DeleteDriver();
                }
            }

            if (currentUser.Role == 1)
            {
                Console.WriteLine("1.Show All Drivers ");

                choosedAction = Convert.ToInt32(Console.ReadLine());

                if (choosedAction == 1)
                {
                    driverMenu.ShowDrivers();
                }

            }

            if (currentUser.Role == 3)
            {

            }

            if(currentUser.Role == 4)
            {

            }
        }

    }
}
