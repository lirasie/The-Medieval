using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.building
{
    class GreenBuilding : Building
    {
        public GreenBuilding(string name, int cost)
        {
            buildingColor = Color.Green;
            buildingName = name;
            this.buildingCost = cost;
        }
    }
}
