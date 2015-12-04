using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.building.purpleBuilding
{
    class University : PurpleBuilding
    {
        public University()
        {
            this.BuildingName = "University";
            this.BuildingCost = 6;
        }

        public override void BuildingFunction()
        {
            this.BuildingCost = 8;
            
        }
    }
}

