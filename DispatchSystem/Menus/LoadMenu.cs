using DispatchSystem.Models;
using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Menus
{
    public class LoadMenu
    {
        LoadService loadService = new LoadService();

        public void Addingload()
        {
            Console.WriteLine("Please enter Load# : ");
            string loadNumber = Console.ReadLine();

            Console.WriteLine("Please enter Brokerage: ");
            string brokerage = Console.ReadLine();

            Console.WriteLine("Please enter Pickup Location: ");
            string pickupLocation = Console.ReadLine();

            Console.WriteLine("Please enter Delivery Location: ");
            string deliveryLocation = Console.ReadLine();

            Console.WriteLine("Please enter Loaded Miles:");
            int loadedMiles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Driver Rate: ");
           decimal driverRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter Profit: ");
           decimal profit = Convert.ToDecimal(Console.ReadLine());

            loadService.AddLoad(loadNumber, brokerage, pickupLocation, deliveryLocation, loadedMiles, driverRate, profit);
        }

        public void ShowLoads()
        {
            loadService.ShowAllLoads();
        }


        public void Deleteload()
        {
            Console.WriteLine("Please enter loadNumber for delete the load:");
            string loadNumber = Console.ReadLine();

            loadService.DeleteLoad(loadNumber);
        }

    }
}

