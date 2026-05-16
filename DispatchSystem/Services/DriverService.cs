using DispatchSystem.Interfaces;
using DispatchSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Services
{
    public class DriverService : IDriverActions
    {
        List<Driver> drivers = new List<Driver>();

        public void AddDriver(string firstName, string lastName, int unitNumber, int phoneNumber, string email, string licenseNumber, string vehicleType, bool isAvailable, bool citizen, bool criminalRecord)
        {
            Driver newDriver = new Driver()
            {
                FirstName = firstName,
                LastName = lastName,
                UnitNumber = unitNumber,
                PhoneNumber = phoneNumber,
                Email = email,
                LicenseNumber = licenseNumber,
                VehicleType = vehicleType,
                IsAvailable = isAvailable,
                Citizen = citizen,
                CriminalRecord = criminalRecord
            };
            drivers.Add(newDriver);
        }

        public void ShowAllDrivers()
        {
            foreach (Driver driver in drivers)
            {
                Console.WriteLine($"First Name: {driver.FirstName}, Last Name: {driver.LastName}, Unit Number: {driver.UnitNumber}, Phone Number: {driver.PhoneNumber}, Email: {driver.Email}, License Number: {driver.LicenseNumber}, Vehicle Type: {driver.VehicleType}, Is Available: {driver.IsAvailable}, Citizen: {driver.Citizen}, Criminal Record: {driver.CriminalRecord}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        public void DeleteDriver(int unitNumber)
        {
            Driver foundDriver = null;
            foreach (var driver in drivers)
            {
                if (driver.UnitNumber == unitNumber)
                {
                    foundDriver = driver;
                    break;
                }
            }

            if (foundDriver != null)
            {
                drivers.Remove(foundDriver);
            }
        }

        public Driver GetDriverByUnitNumber(int unitNumber)
        {
            foreach (var driver in drivers)
            {
                if (driver.UnitNumber == unitNumber)
                {
                    return driver;
                }
            }
            return null;
        }
    }
}
