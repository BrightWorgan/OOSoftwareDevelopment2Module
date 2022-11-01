using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagement
{
    internal class ElectricVehicle : DeliveryVehicle
    {
        private int kiloWattHours;
        public int KiloWattHours { get; set; } 

        private int kmsPerWattHr;
        public int KmsPerWattHr { get; set; }

        // constructor
        public ElectricVehicle(string _vechMake, string _vechModel, DateTime _vechManDate, string _vechReg, int _kiloWattHours, int _kmsPerWattHr ) : base(string _vechMake , string _vechModel , DateTime _vechManDate, string _vechReg)
        {
            this.KiloWattHours = _kiloWattHours;
            this.KmsPerWattHr = _kmsPerWattHr;
        }

        //
        public override double RemainingDistance()
        {
            return KmsPerWattHr * kiloWattHours;
        }

        //
        public override void Refuel()
        {
            Console.WriteLine("\t The Vehicle " + VechReg + " ");
        }
    }
}
