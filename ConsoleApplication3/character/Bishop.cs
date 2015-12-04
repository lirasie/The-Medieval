using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.character
{
    class Bishop : Character 
    {
        public Bishop(List<Building> builded, int numDraws, int getCoins)
            : base(numDraws, getCoins)
        {
            foreach (Building building in builded)      //속성에 맞는 건물
            {
                if (building.Color.Equals(Color.Blue))
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
