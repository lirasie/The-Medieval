using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.building.purpleBuilding
{
    class Blacksmithroom : PurpleBuilding
    {
        public Blacksmithroom()
        {
            this.BuildingName = "Blacksmith store";
            this.BuildingCost = 8;
        }
        public override void BuildingFunction(Client me)
        {
            me.UserCoins = -3;
            //카드 뽑기는 어떻게 하더라..

        }
    }
}
