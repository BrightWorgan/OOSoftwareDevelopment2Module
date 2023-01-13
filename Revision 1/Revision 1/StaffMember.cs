using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_1
{
    public enum CompanyPosition
    {
        CEO,
        CTO,
        Hiring_Managemnet,
        Human_Resources,
        Marketing_Department_Head,
        Sales_Department_Head,
        Legal_Department_Head,
        Governance_Risk_and_Compliance_Department_Head,
        Governance_Risk_and_Compliance_Engineer,
        Customer_Service_Officer,
        Social_Media_Manager,
        Social_Media_Engineer,
        Graphic_Designer,
        Reseach_and_Design_Department_Head,
        Senior_Research_Software_Development_Engineer,
        Quantum_Software_Researcher,
        Reseach_and_Design_Engineer,
        Project_Manager,
        Lead_Developer,
        Senior_Developer,
        Mid_Level_Developer,
        Developer,
        Dev_Ops_Department_Head,
        Dev_Ops_Lead,
        Dev_Ops_Engineer,
        Quality_Assurance_Department_Head,
        Quality_Assurance_Lead,
        Senior_Quality_Assurance_Engineer,
        Quality_Assurance_Engineer,
        IT_Department_Head,
        IT_Admin,
        IT_Engineer,
        Secretary,
        Logistics_Supervisor,
        Logistics_Officer,
        Security_Department_Head,
        Cyber_Security_Supervisor,
        Cyber_Security_Officer,
        Head_of_Security,
        Security_Supervisor,
        Security_Guard,
        Health_and_Safety_Officer,
        Kitchen_Manager,
        Executive_Chef,
        Executive_Sous_Chef,
        Pastry_Sous_Chef,
        Baker,
        Sous_Chef,
        Saucier,
        Grillardin,
        Garde_Manger,
        Friturier,
        Chef_de_Partie,
        Chef_de_Tournant,
        Entremetier,
        Commis_1,
        Commis_2,
        Commis_3,
        Kitchen_Porter,
        Esculelerie,
        Trainee_1,
        Trainee_2,
        Cleaning_Team_Manager,
        Cleaning_Team_Supervisor,
        Cleaning_Team_Officer,
        Education_Outreach_Officer,
        Assessibility_Officer,
        Student_Work_Experience,
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

    // constructor
    public StaffMember(string Name, int Age, Gender PersonsGender, CompanyPosition Position, DietartyRequirement Diet, SafetyEquipment SafetyGear, CommuteTypes PrimaryCommuteMethod, CommuteTypes SecondCommuteMethod)
        {
            this.Name = Name;
            this.Age = Age;
            this.PersonsGender = PersonsGender;
            this.Position = Position;
            this.SafetyGear = SafetyGear;
            this.Diet = Diet;
            this.PrimaryCommuteMethod = PrimaryCommuteMethod;
            this.SecondCommuteMethod = SecondCommuteMethod;
        }
    }

    // ToString()
    public override string ToString()
    {
        return String.Format("\t: {0}\n\t: {1}\n\ts: {2}, {3}, {4}\n\tg: {5}\n\t_______________", Name, Age,Position, Diet, SafetyGear, PrimaryCommuteMethod, SecondCommuteMetho);
    }
}
