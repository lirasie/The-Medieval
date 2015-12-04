using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.character
{
    class General : Character
    {
        public General(List<Building> builded, int numDraws, int getCoins)
            : base(numDraws, getCoins)
        {
            foreach (Building building in builded)
            {
                if (building.Color.Equals(Color.Red))
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
