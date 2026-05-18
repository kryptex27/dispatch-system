using DispatchSystem.Models;
using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DispatchSystem.Menus
{
    public class DispatcherMenu
    {
        LoadMenu loadMenu;
        DispatcherService dispatcherService = new DispatcherService();
        DriverService driverService;
        LoadService loadService;

        public DispatcherMenu(DriverService driverService, LoadService loadService)
        {
            this.driverService = driverService;
            this.loadService = loadService;
            loadMenu = new LoadMenu(loadService);
        }
        public void AddingLoad()
        {
            loadMenu.Addingload();
        }

        public void AssigningLoadToDriver()
        {
            Console.WriteLine("Please enter Unit: ");
            int unitNumber = Convert.ToInt32(Console.ReadLine());

            Driver driver = driverService.GetDriverByUnitNumber(unitNumber);

            Console.WriteLine("Please enter Load Number: ");
            string loadNumber = Console.ReadLine();

            Load load = loadService.GetLoadByLoadNumber(loadNumber);

            dispatcherService.AssingLoadToDriver(driver, load);

        }

        public void ShowDispatcherMenu()
        {
            while (true) 
            {
                Console.WriteLine("1. Add Load");
                Console.WriteLine("2. Show All Loads");
                Console.WriteLine("3. Delete Load");
                Console.WriteLine("4. Assign Load to Driver");
                int choosedAction = Convert.ToInt32(Console.ReadLine());
                if (choosedAction == 1)
                {
                    AddingLoad();
                }
                else if (choosedAction == 2)
                {
                    loadMenu.ShowLoads();
                }
                else if (choosedAction == 3)
                {
                    loadMenu.Deleteload();
                }
                else if (choosedAction == 4)
                {
                    AssigningLoadToDriver();
                }
            }

        }
    }
}
