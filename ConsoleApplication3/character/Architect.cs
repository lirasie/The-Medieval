using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.character
{
    class Architect : Character
    {
        public Architect(int numDraws, int getCoins)
            : base(numDraws, getCoins)
        {
             
        }
        public void ability(int numDraw, int numBuild)
        {
            drawMoreCard(numDraw);
            buildMoreBuilding(numBuild);
        }
        private void drawMoreCard(int numDraw)
        {
            numDraw = numDraw + 2;
        }
        private void buildMoreBuilding(int numBuild)
        {
            numBuild = numBuild + 2;
        }
        
    }
}
