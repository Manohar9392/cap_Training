using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_cargo_solutions
{

    public enum TransportMode
    {
        Air = 50,
        Sea = 15,
        Land = 25
    }




    public class ShipmentDetails : Shipment
        {
            public static List<Shipment> Shipments = new List<Shipment>();

            // ✅ Constructor (base call is VALID here)
            public ShipmentDetails(string code, string mode, double weight, int days)
                : base(code, mode, weight, days)
            {
                Shipments.Add(this);
                double cost = CalculateTotalCost(weight, mode, days);
                Console.WriteLine($"The total shipping cost is {cost:F2}");
                Console.WriteLine("Shipment added successfully.");
            }
            
        




        public  static bool ValidateShipmentCode(string code)
            {
                if (code.Length != 7)
                    return false;

                if (code[0] == 'G' && code[1] == 'C' && code[2] == '#')
                {
                    for (int i = 3; i < 7; i++)
                    {
                        if (!char.IsDigit(code[i]))
                            return false;
                    }
                    return true;
                }
                return false;
            }

            public double CalculateTotalCost(double weight, string mode, int days)
            {
                int rate = 0;

                if (mode == "Air")
                    rate = 50;
                else if (mode == "Sea")
                    rate = 15;
                else if (mode == "Land")
                    rate = 25;

                return Math.Round((weight * rate) + Math.Sqrt(days), 2);
            }
        }
    }


