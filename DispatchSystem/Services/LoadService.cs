using DispatchSystem.Interfaces;
using DispatchSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DispatchSystem.Services
{

    public class LoadService : ILoadActions
    {
        private List<Load> loads = new List<Load>();


        public void AddLoad(string loadNumber, string brokerage, string pickupLocation, string deliveryLocation, int loadedMiles, decimal driverRate, decimal profit)
        {

            Load newload = new Load()
            {
                LoadNumber = loadNumber,
                Brokerage = brokerage,
                PickupLocation = pickupLocation,
                DeliveryLocation = deliveryLocation,
                LoadedMiles = loadedMiles,
                Rate = driverRate,
                Profit = profit,
                Status = "Available"

            };
            loads.Add(newload);
        }
        public void ShowAllLoads()
        {
            foreach (Load load in loads)
            {
                Console.WriteLine($"Load Number: {load.LoadNumber}, Brokerage: {load.Brokerage}, Pickup Location: {load.PickupLocation}, Delivery Location: {load.DeliveryLocation}, Loaded Miles: {load.LoadedMiles}, Driver Rate: {load.Rate}, Status: {load.Status}");

                Console.WriteLine("-----------------------------------------------------");
            }
        }

        public Load GetLoadByLoadNumber(string loadNumber)
        {
            foreach (var load in loads)
            {
                if (load.LoadNumber == loadNumber)
                {
                    return load;
                }
            }
            return null;
        }
        public void DeleteLoad(string loadNumber)
        {

            Load foundLoad = null;

            foreach (var load in loads)
            {
                if (load.LoadNumber == loadNumber)
                {
                    foundLoad = load;
                    break;
                }
            }

            if (foundLoad != null)
            {
                loads.Remove(foundLoad);
            }
        }

        public decimal CalculateAvarageProfitRate()
        {


            if (loads.Count > 0)
            {
                decimal totalProfit = 0;

                foreach (var load in loads)
                {
                    totalProfit += load.Profit;
                }
                return totalProfit / loads.Count;
            }
            return 0;
        }


        public decimal GetTotalProfit()
        {
            decimal totalProfit = 0;
            foreach (var load in loads)
            {
                totalProfit += load.Profit;
            }
            return totalProfit;
        }

    }
}





