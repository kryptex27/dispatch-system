using DispatchSystem.Interfaces;
using DispatchSystem.Menus;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using DispatchSystem.Models;

namespace DispatchSystem.Services
{
    public class DispatcherService
    {
        public void CreateLoad(LoadService loadService)
        {
            LoadMenu loadMenu = new LoadMenu(loadService);
            loadMenu.Addingload();
        }

        public void AssingLoadToDriver(Driver driver, Load load)
        {
            driver.IsAvailable = false;
            load.Status = "Assigned";
        }

        internal void DispatcherProfit(Dispatcher dispatcher, LoadService loadService)
        {
            dispatcher.Profit = loadService.GetTotalProfit();
        }

        internal void DispatcherAvarageProfit(Dispatcher dispatcher, LoadService loadService)
        {
            dispatcher.AvarageProfit = loadService.CalculateAvarageProfitRate();
        }
    }


}

