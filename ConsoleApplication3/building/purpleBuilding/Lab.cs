using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.building.purpleBuilding
{
    class Lab : PurpleBuilding
    {
        public Lab()
        {
            this.BuildingName = "Labatory";
            this.BuildingCost = 5;
        }
        public override void BuildingFunction(Client me)
        {
            //카드 1장 버리기

            me.UserCoins = 1;    
        }
        
    }
}
