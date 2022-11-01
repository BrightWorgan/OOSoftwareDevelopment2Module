// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using FleetManagement;

namespace FleetData
{
    public class Program
    {
        static void Main()
        {
            //Console.WriteLine("Main Method");
            // Add vechicles
            ElectricVehicle EV1 = new ElectricVehicle("Tesla", "Model-S", new DateTime(1, 1, 2022), "221-D-2003", 2, 32 );
            ElectricVehicle EV2 = new ElectricVehicle("Tesla", "Model-X", new DateTime(1, 1, 2022), "222-W-2053", 2, 32);
            ElectricVehicle EV3 = new ElectricVehicle("Nissan", "Leaf", new DateTime(1, 1, 2022), "221-c-4303", 2, 32);
            ICEVehicle DV1 = new ICEVehicle("Pontiac Trans Am", "KITT", new DateTime(1, 1, 1982), "KNIGHT", 3, 120);
            ICEVehicle DV2 = new ICEVehicle("Dodge", "Charger", new DateTime(1, 1, 1969), "CNH-320", 4, 420);
            ICEVehicle DV3 = new ICEVehicle("Chevrolet", "Impala", new DateTime(1, 1, 1967), "CNK-80Q3", 2, 200);
        }

        static void CheckallDistances(List<DeliveryVehicle> _vehicles)
        {
            foreach (var dv in _vehicles)
            {
                double remainingKms =dv.RemainingDistance();
                Console.WriteLine();
                if (remainingKms > 20)
                {
                    dv.Refuel();
                }
            }
        }
    }
}