using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Revision_1
{
    public  class Manager : StaffMember
    {
        // Attribrutes
        public string Access1 { get; set; }
        public string SecurityCard{ get; set; }

        // Construtor
        public Manager(string Name, int Age, Gender PersonsGender, CompanyPosition Position, DietartyRequirement Diet, SafetyEquipment SafetyGear, CommuteTypes PrimaryCommuteMethod, CommuteTypes SecondCommuteMethod, string UserName, string _loginCode, string Access1, string SecurityCard) : base(Name, Age, PersonsGender, Position, Diet, SafetyGear, PrimaryCommuteMethod, SecondCommuteMethod, UserName, _loginCode)
        {
            this.Access1 = Access1;
            this.SecurityCard = SecurityCard;
        }

        // ToString()
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
