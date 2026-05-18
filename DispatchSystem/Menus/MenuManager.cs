using DispatchSystem.Models;
using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Menus
{
    public class MenuManager
    {
        DriverService driverService = new DriverService();
        LoadService loadService = new LoadService();
        DriverMenu driverMenu;
        DispatcherMenu dispatcherMenu;
        OperationMenu operationMenu;
        HrService hrService;
        LoadMenu loadMenu;
        HrMenu hrMenu;
        AdminMenu adminMenu;

        public User currentUser;
        int choosedAction;

        public MenuManager()
        {
            driverMenu = new DriverMenu(driverService);
            dispatcherMenu = new DispatcherMenu(driverService, loadService);
            operationMenu = new OperationMenu(loadService, new OperationService());
            hrService = new HrService(driverMenu);
            hrMenu = new HrMenu(hrService);
            loadMenu = new LoadMenu(loadService);
            adminMenu = new AdminMenu(driverMenu, loadMenu, operationMenu, dispatcherMenu, hrMenu);
        }


        public void ShowMenu()
        {
            if (currentUser.Role == 1)
            {
                dispatcherMenu.ShowDispatcherMenu();
            }
            else if (currentUser.Role == 2)
            {
                hrMenu.ShowHrMenu();
            }
            else if (currentUser.Role == 3)
            {
                operationMenu.ShowOperationMenu();
            }
            else if (currentUser.Role == 4)
            {
                adminMenu.ShowAdminMenu();
            }
        }

    }
}
