using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.character
{
    class King : Character
    {
        public King(List<Building> builded, int numDraws, int getCoins)
            : base(numDraws, getCoins)
        {
            
            foreach (Building building in builded)
            {
                if (building.Color.Equals(Color.Yellow))
                {
                    getCoins = getCoins + 1;
                }
            }
        }

        public void ability()
        {
            
        }


    }
}
