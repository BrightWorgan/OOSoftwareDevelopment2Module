using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management_CAPractice
{
    public class ICEVehicle : DeliveryVehicle
    {
        // Litres, KmsPerLitre
        public int Litres { get; set; }
        public int KmsPerLitre { get; set; }

        // constructor
        public ICEVehicle(VechType _make, string _model, DateOnly _manufactureDate, string _reg, int _litres, int _kmsPerLitre) : base(_make, _model, _manufactureDate, _reg)
        {
            this.Litres = _litres;
            this.KmsPerLitre = _kmsPerLitre;
        }

        // method
        public override double RemainingDistance()
        {
            return Litres * KmsPerLitre;
        }

        // method
        public override string Refuel()
        {
            return Reg + "\n\t " + Litres * KmsPerLitre + " – ready in 5 minutes";
        }

    }
}
