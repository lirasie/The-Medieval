using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract class PurpleBuilding : Building
    {
        public PurpleBuilding()
        {
            buildingColor = Color.Purple;
        }
        public abstract virtual void BuildingFunction();
        
    }
}
