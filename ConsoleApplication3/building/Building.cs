using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    
    abstract class Building
    {
        protected string buildingName;
        protected Color buildingColor;
        protected int buildingCost;

        public string BuildingName
        {
            get; set;
        }

        public Color BuildingColor
        {
            get
            {
                return buildingColor;
            }
        }
        public int BuildingCost
        {
            get
            {
                return buildingCost;
            }
            set
            {
                buildingCost = value;
            }
        }
    }
}
