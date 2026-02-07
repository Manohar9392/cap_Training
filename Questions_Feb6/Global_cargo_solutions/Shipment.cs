using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_cargo_solutions
{
    public class Shipment
    {
        public string ShipmentCode { get; set; }

        public string TransportMode { get; set; }
        public double Weight { get; set; }

        public int StorageDays { get; set; }
        public Shipment(string shipmentCode, string transportMode, double weight, int storageDays)
        {
            ShipmentCode = shipmentCode;
            TransportMode = transportMode;
            Weight = weight;
            StorageDays = storageDays;
            
            
        }
    }
}
