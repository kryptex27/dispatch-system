using System;
using System.Collections.Generic;
using System.Text;

namespace DispatchSystem.Models
{
    public class Load
    {
        public string LoadNumber { get; set; }

        public string Brokerage { get; set; }

        public string PickupLocation { get; set; }

        public string DeliveryLocation { get; set; }

        public int LoadedMiles { get; set; }

        public decimal Rate { get; set; }

        public decimal Profit { get; set; }

        public string Status { get; set; }

        public decimal AvarageProfitRate { get; set; }
    }
}
