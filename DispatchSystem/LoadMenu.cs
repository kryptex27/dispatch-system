using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem
{
    public class LoadMenu
    {
        LoadService loadService = new LoadService();

        public void Addingload(string loadNumber, string brokerage, string pickupLocation, string deliveryLocation, int loadedMiles, decimal driverRate, decimal profit)
        {
            Console.WriteLine("Please enter Load# : ");
            loadNumber = Console.ReadLine();

            Console.WriteLine("Please enter Brokerage: ");
            brokerage = Console.ReadLine();

            Console.WriteLine("Please enter Pickup Location: ");
            pickupLocation = Console.ReadLine();

            Console.WriteLine("Please enter Delivery Location: ");
            deliveryLocation = Console.ReadLine();

            Console.WriteLine("Please enter Loaded Miles:");
            loadedMiles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Driver Rate: ");
            driverRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter Profit: ");
            profit = Convert.ToDecimal(Console.ReadLine());

            loadService.AddLoad(loadNumber, brokerage, pickupLocation, deliveryLocation, loadedMiles, driverRate, profit);
        }

        public void ShowLoads()
        {
            loadService.ShowAllLoads();
        }

    }
 }

