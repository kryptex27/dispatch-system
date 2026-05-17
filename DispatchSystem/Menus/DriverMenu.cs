using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace DispatchSystem.Menus
{
    public class DriverMenu
    {
        DriverService driverService = new DriverService();

        DriverMenu driverMenu;

        public DriverMenu(DriverService driverService)
        {
            this.driverService = driverService;
        }   

        public void AddingDriver()
        {
            Console.WriteLine("Please enter First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter Unit Number: ");
            int unitNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Phone Number: ");
           int phoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Please enter License Number: ");
            string licenseNumber = Console.ReadLine();

            Console.WriteLine("Please enter Vehicle Type: ");
            string vehicleType = Console.ReadLine();

            Console.WriteLine("Is the driver available? (true/false): ");
           bool isAvailable = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Is the driver a citizen? (true/false): ");
           bool citizen = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Does the driver have a criminal record? (true/false): ");
            bool criminalRecord = Convert.ToBoolean(Console.ReadLine());

            driverService.AddDriver(firstName, lastName, unitNumber, phoneNumber, email, licenseNumber, vehicleType, isAvailable, citizen, criminalRecord);
        }
        public void ShowDrivers()
        {
            driverService.ShowAllDrivers();
        }

        public void DeleteDriver()
        {
            Console.WriteLine("Please enter Unit Number for delete the driver:");
            int unitNumber = Convert.ToInt32(Console.ReadLine());

            driverService.DeleteDriver(unitNumber);
        }

    }
}
