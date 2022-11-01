using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagement
{
    abstract class DeliveryVehicle
    {
        //as a make, model, manufacture date and a registration
        private string vechMake;
        public string VechMake { get { return vechMake; } }

        private string vechModel ;
        public string VechModel { get { return vechModel; } }

        private DateTime vechManDate;
        public DateTime VechManDate { get { return vechManDate; } }

        private string vechReg;
        public string VechReg { get { return vechReg; } }

        // constructor
        public DeliveryVehicle(string _vechMake, string _vechModel,DateTime _vechManDate, string _vechReg )
        {
            // 
            if (String.IsNullOrEmpty(_vechMake) || String.IsNullOrEmpty(_vechModel) || String.IsNullOrEmpty(_vechReg))
                {
                throw new ArgumentException("\n\tVehicle Details must be vaild!");
                }

            vechMake = _vechMake;
            vechModel = _vechModel;
            vechManDate = _vechManDate;
            vechReg = _vechReg;
        }

        // abstract method
        public abstract double RemainingDistance();

        // abstract method
        public abstract void Refuel();

        //
        public int CompareTo(object obj)
        {
            return VechReg.CompareTo(((DeliveryVehicle)obj).VechReg.CompareTo(VechReg);
        }
    }
}
