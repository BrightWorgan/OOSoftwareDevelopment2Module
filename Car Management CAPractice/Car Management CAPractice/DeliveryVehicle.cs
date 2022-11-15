using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Management_CAPractice
{
    // enum
    public enum VechType
    {
        Tesla,
        Nissan,
        Volkswagon,
        Toyota
    }
    public abstract class DeliveryVehicle : IComparable
    {
        // make, model, manufacture date, registration
        private VechType make;
        public VechType Make 
        { 
            get 
            { 
                return make; 
            } 
            set 
            { 
                make = value;
            } 
        }
        private string model;
        public string Model
        {
            get { return model; }
        }

        private DateOnly manufactureDate;
        public DateOnly ManufactureDate { get { return manufactureDate; } }

        private string reg;
        public string Reg { get { return reg; } }


        // constructor
        public DeliveryVehicle(VechType _make, string _model, DateOnly _manufactureDate, string _reg)
        {
            this.make = _make;
            this.model = _model;
            this.manufactureDate = _manufactureDate;
            this.reg = _reg;
        }

        public abstract double RemainingDistance();
        
        public abstract string Refuel();

        public int CompareTo(object? obj)
        {
            return((DeliveryVehicle)obj).Reg.CompareTo(Reg);
        }

    }
}
