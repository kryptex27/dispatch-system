using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Interfaces
{
    public interface ILoadActions
    {
        void AddLoad(string loadNumber, string brokerage, string pickupLocation, string deliveryLocation, int loadedMiles, decimal driverRate, decimal profit);
        void ShowAllLoads();
        void DeleteLoad(string loadNumber);
    }
}
