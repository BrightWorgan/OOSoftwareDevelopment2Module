using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_1
{
    public enum CompanyPosition
    {
        Management,
        Development,
        IT,
        HR,
        Legal,
        Assessibilty,
        Education,
        Research_and_Development,
        Kitchen,
        Cleaning,
        Security, 
        Other,
    }
    public enum Gender
    {
        Female,
        Male,
        Transgender,
        Two_Spirit,
        Non_Binary,
        Gender_Fluid,
        Agender,
    }

    public enum DietartyRequirement
    {
        Vegan_Plant_Based,
        Gluten_Free,
        Tree_Nut_Alllergy,
        Nut_Allergy,
        Soya_Allergy,
        Egg_Allergy,
        Shellfish_Allergy,
        Other_Allergy,
        Halal,
        Kosher,
        None,
    }

    public enum SafetyEquipment
    {
        Security_Equipment,
        Kitchen_gear,
        Cleaning_Equipment,
        Basic_Office,
    }

    public enum CommuteTypes
    {
        Walk,
        Run,
        Cycyle,
        EBike,
        Skate,
        Luas,
        DART,
        Train,
        Dublin_Bus,
        Bus,
        Car,
        Electric_Car,
        Car_Sharing,
        Electric_Car_Sharing,
        Other,
        None,
    }
    public class StaffMember
    {
        public string Name { get; set; }
        public CompanyPosition Position { get; set; }
        public int Age { get; set; }
        public Gender PersonsGender {get; set;}
        public DietartyRequirement Diet { get; set;}
        public SafetyEquipment SafetyGear {get; set;}
        public CommuteTypes PrimaryCommuteMethod {get; set;}
        public CommuteTypes SecondCommuteMethod {get; set;}
        public string UserName {get; set;}
        private string _LoginCode { get; set;}

    // constructor
        public StaffMember(string Name, int Age, Gender PersonsGender, CompanyPosition Position, DietartyRequirement Diet, SafetyEquipment SafetyGear, CommuteTypes PrimaryCommuteMethod, CommuteTypes SecondCommuteMethod, string UserName, string _loginCode)
        {
            this.Name = Name;
            this.Age = Age;
            this.PersonsGender = PersonsGender;
            this.Position = Position;
            this.SafetyGear = SafetyGear;
            this.Diet = Diet;
            this.PrimaryCommuteMethod = PrimaryCommuteMethod;
            this.SecondCommuteMethod = SecondCommuteMethod;
            this.UserName = UserName;
            this._LoginCode = _loginCode;
        
        }

        // ToString()
        public override string ToString()
        {
            return String.Format("\tName: {0}\n\tAge: {1}\n\tGender: {2}\n\tPosition: {3}\n\tPPE Required: {4}\n\tDietaryRequirement: {5}\n\tCommute Method(s): {6}, {7},\n\t_______________", Name, Age, PersonsGender, Position, SafetyGear, Diet, PrimaryCommuteMethod, SecondCommuteMethod);
        }
    }

   
}
