using DispatchSystem.Menus;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{
    internal class AdminService
    {
        DriverMenu driverMenu;
        LoadMenu loadMenu;
        OperationMenu operationMenu;
        HrService hrService;
        DispatcherMenu dispatcherMenu;

        public AdminService(DriverMenu driverMenu, LoadMenu loadMenu, OperationMenu operationMenu, HrService hrService, DispatcherMenu dispatcherMenu)
        {
            this.driverMenu = driverMenu;
            this.loadMenu = loadMenu;
            this.operationMenu = operationMenu;
            this.hrService = hrService;
            this.dispatcherMenu = dispatcherMenu;
        }

    }

}
