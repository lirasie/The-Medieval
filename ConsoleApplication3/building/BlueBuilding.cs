using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.building
{
    class BlueBuilding : Building
    {
        public BlueBuilding(string name, int cost)
        {
            buildingColor = Color.Blue;
            buildingName = name;
            this.buildingCost = cost;
        }
    }
}
