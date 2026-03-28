using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Models
{
    public class Load
    {
        public string LoadNumber { get; set; }

        public string BrokerName { get; set; }

        public string PickupLocation { get; set; }

        public string DeliveryLocation { get; set; }

        public int TotalMiles { get; set; }

        public decimal Rate { get; set; }

        public string Status { get; set; }
    }
}
