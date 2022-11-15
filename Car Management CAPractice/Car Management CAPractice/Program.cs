// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Car_Management_CAPractice
{
    public class Program
    {
        public static void Main()
        {
            //(VechType _make, string _model, DateOnly _manufactureDate, reg, kiloWattHours,kmsPerKWattHour
            ElectricVehicle c1 = new ElectricVehicle(VechType.Tesla, "Series - S", new DateOnly(2022, 1, 1), "222-D-1690", 25, 300);
            ElectricVehicle c2 = new ElectricVehicle(VechType.Nissan, "Leaf", new DateOnly(2020, 1, 1), "202-D-20320", 25, 300);
            ICEVehicle c4 = new ICEVehicle(VechType.Toyota, "modelOne", new DateOnly(2012, 1, 1), "12-D-46457", 25, 300);
            ICEVehicle c5 = new ICEVehicle(VechType.Volkswagon, "Golf", new DateOnly(2010, 1, 1), "10-D-27820", 25, 300);

            List<DeliveryVehicle> fleetList = new List<DeliveryVehicle>();

            fleetList.Add(c1);
        }

        // list with two of each vehicle types

        //
        //List fleetList.Add();
        public void myFunc()
        {
            
        }
        

        //
        static void CheckAllDistanceLimits()

        {

        }
    }
    
}