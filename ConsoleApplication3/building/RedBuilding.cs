using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.building
{
    class RedBuilding : Building
    {
        public RedBuilding(string name, int cost)
        {
            buildingColor = Color.Red;
            buildingName = name;
            this.buildingCost = cost;
        }
    }
}
