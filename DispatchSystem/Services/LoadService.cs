using DispatchSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{

    public class LoadService
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
            }
        }
    }
}





