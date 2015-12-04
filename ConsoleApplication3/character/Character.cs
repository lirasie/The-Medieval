using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    abstract class Character
    {
        protected Character(int numDraw, int getCoins)
        {
            int select;
            //user의 선택
            switch (select)
            {
                case 1:
                    numDraw = 1;
                    break;
                case 2:
                    getCoins = 1;
                    break;
                default:
                    break;
            }
        }
        protected string name;
        protected int order;

        abstract public virtual void ability();

    }
}
