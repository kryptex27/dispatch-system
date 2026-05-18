using DispatchSystem.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{
    internal class HrService
    {
        DriverMenu driverMenu;
        public HrService(DriverMenu driverMenu)
        {
            this.driverMenu = driverMenu;
        }

        public void CreateDriver( )
        {
            driverMenu.AddingDriver();
        }

        public void ShowAllDrivers()
        {
            driverMenu.ShowDrivers();
        }

        public void DeleteDriver()
        {
            driverMenu.DeleteDriver();
        }


    }
}
