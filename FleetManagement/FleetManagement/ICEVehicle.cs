using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagement
{
    internal class ICEVehicle : DeliveryVehicle
    {
        // Litres and KmsPerLitre
        private int litres;
        public int Litres { get { return litres; } set { litres = value; } }

        private int kmsPerLitre;
        public int KmsPerLitre { get { return KmsPerLitre; } set { KmsPerLitre = value; } }
        // constructor
        public ICEVehicle(string _vechMake, string _vechModel, DateTime _vechManDate, string _vechReg, int _litres, int _kmsPerLitre) : base(_vechMake, _vechModel, _vechManDate, _vechReg)
        {
            this.Litres = _litres;
            this.KmsPerLitre = _kmsPerLitre;
        }

        //
        public override void Refuel()
        {
            throw new NotImplementedException();
        }

        //
        public override double RemainingDistance()
        {
            throw new NotImplementedException();
        }
    }
}
