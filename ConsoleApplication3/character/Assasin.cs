using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.character
{
    class Assasin : Character
    {
        public Assasin(Character target, List<Client> users, List<Building> builded, int numDraws, int getCoins)
            : base(numDraws, getCoins)
        {
            ability(target, users);
        }

        public Character ability(Character target, List<Client> users)
        {
            
            //client로부터 암살하고자 하는 대상을 받아옮
            return target;
        }
    }
}
