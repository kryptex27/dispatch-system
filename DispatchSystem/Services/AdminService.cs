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

        public AdminService(DriverMenu driverMenu, LoadMenu loadMenu, OperationMenu operationMenu, HrService hrService)
        {
            this.driverMenu = driverMenu;
            this.loadMenu = loadMenu;
            this.operationMenu = operationMenu;
            this.hrService = hrService;
        }


        public void ShowAdminMenu()
        {

        }
    }


}
