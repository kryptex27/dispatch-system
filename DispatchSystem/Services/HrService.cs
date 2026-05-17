using DispatchSystem.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{
    internal class HrService
    {
        DriverMenu driverMenu;

        public HrService(DriverService driverService)
        {
            driverMenu = new DriverMenu(driverService);
        }

        public void CreateDriver(DriverService driverService)
        {
            driverMenu.AddingDriver();
        }

        public void ShowAllDrivers(DriverService driverService)
        {
            driverMenu.ShowDrivers();
        }

        public void DeleteDriver(DriverService driverService)
        {
            driverMenu.DeleteDriver();
        }


    }
}
