using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.building
{
    class YellowBuilding : Building
    {
        public YellowBuilding(string name, int cost)
        {
            buildingColor = Color.Yellow;
            buildingName = name;
            this.buildingCost = cost;
        }
    }
}
