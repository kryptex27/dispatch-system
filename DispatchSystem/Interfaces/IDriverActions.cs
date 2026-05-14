using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Interfaces
{
    public interface IDriverActions
    {
        void AddDriver(string firstName, string lastName, int unitNumber, int phoneNumber, string email, string licenseNumber, string vehicleType, bool isAvailable, bool citizen, bool criminalRecord);
        void DeleteDriver(int unitNumber);
        void ShowAllDrivers();
    }
}
