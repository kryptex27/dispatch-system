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
    }
}
