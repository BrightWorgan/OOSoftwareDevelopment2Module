using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management_CAPractice
{
    public class ElectricVehicle : DeliveryVehicle
    {
        // KiloWattHours, KmsPerKWattHour
        public int KiloWattHours { get; set; }
        public int KmsPerKWattHour { get; set; }

        // constructor
        public ElectricVehicle(VechType _make, string _model, DateOnly _manufactureDate, string _reg, int _kiloWattHours, int _kmsPerKWattHour) : base(_make, _model, _manufactureDate, _reg)
        {
            KiloWattHours = _kiloWattHours;
            KmsPerKWattHour = _kmsPerKWattHour;
        }

        // method
        public override double RemainingDistance()
        {
            return KiloWattHours * KmsPerKWattHour;
        }

        // method
        public override string Refuel()
        {
            return Reg + "\n\t " + KiloWattHours * KmsPerKWattHour + " – ready in 3.5 hours";
        }
    }

}

