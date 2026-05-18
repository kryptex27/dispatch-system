using DispatchSystem.Models;
using DispatchSystem.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Menus
{
    internal class OperationMenu
    {
        LoadService loadService;
        OperationService operationService;

        public OperationMenu(LoadService loadService, OperationService operationService)
        {
            this.loadService = loadService;
            this.operationService = operationService;
        }

        public void MarkAsDelivered()
        {
            loadService.ShowAllLoads();
            Console.WriteLine("Please enter Load Number: ");
            string loadNumber = Console.ReadLine();

            Load load = loadService.GetLoadByLoadNumber(loadNumber);

            if (load != null)
            {
                operationService.MarkAsDelivered(load);
                Console.WriteLine($"Load {load.LoadNumber} marked as delivered.");
            }
            else
            {
                Console.WriteLine("Load not found. Please check the Load Number and try again.");
            }
        }
        public void MarkAsPickingUp()
        {
            loadService.ShowAllLoads();
            Console.WriteLine("Please enter Load Number: ");
            string loadNumber = Console.ReadLine();
            Load load = loadService.GetLoadByLoadNumber(loadNumber);
            if (load != null)
            {
                operationService.MarkAsPickingUp(load);
                Console.WriteLine($"Load {load.LoadNumber} marked as picking up.");
            }
            else
            {
                Console.WriteLine("Load not found. Please check the Load Number and try again.");
            }
        }
        public void MarkAsPickedUp()
        {
            loadService.ShowAllLoads();
            Console.WriteLine("Please enter Load Number: ");
            string loadNumber = Console.ReadLine();
            Load load = loadService.GetLoadByLoadNumber(loadNumber);
            if (load != null)
            {
                operationService.MarkAsPickedUp(load);
                Console.WriteLine($"Load {load.LoadNumber} marked as picked up.");
            }
            else
            {
                Console.WriteLine("Load not found. Please check the Load Number and try again.");
            }
        }

        public void MarkAsCancelled()
        {
            loadService.ShowAllLoads();
            Console.WriteLine("Please enter Load Number: ");
            string loadNumber = Console.ReadLine();
            Load load = loadService.GetLoadByLoadNumber(loadNumber);
            if (load != null)
            {
                operationService.MarkAsCancelled(load);
                Console.WriteLine($"Load {load.LoadNumber} marked as cancelled.");
            }
            else
            {
                Console.WriteLine("Load not found. Please check the Load Number and try again.");
            }

        }

        public void MarkAsInTransit()
        {
            loadService.ShowAllLoads();
            Console.WriteLine("Please enter Load Number: ");
            string loadNumber = Console.ReadLine();
            Load load = loadService.GetLoadByLoadNumber(loadNumber);
            if (load != null)
            {
                operationService.MarkAsInTransit(load);
                Console.WriteLine($"Load {load.LoadNumber} marked as in transit.");
            }
            else
            {
                Console.WriteLine("Load not found. Please check the Load Number and try again.");
            }

        }

        public void ShowOperationMenu()
        {
            Console.WriteLine("1. Mark Load as Delivered");
            Console.WriteLine("2. Mark Load as Picking Up");
            Console.WriteLine("3. Mark Load as Picked Up");
            Console.WriteLine("4. Mark Load as Cancelled");
            Console.WriteLine("5. Mark Load as In Transit");

            int choosedAction = Convert.ToInt32(Console.ReadLine());

            if (choosedAction == 1)
            {
                MarkAsDelivered();
            }
            else if (choosedAction == 2)
            {
                MarkAsPickingUp();
            }
            else if (choosedAction == 3)
            {
                MarkAsPickedUp();
            }
            else if (choosedAction == 4)
            {
                MarkAsCancelled();
            }
            else if (choosedAction == 5)
            {
                MarkAsInTransit();
            }
        }
    }
}
