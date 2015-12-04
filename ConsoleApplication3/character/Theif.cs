using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.character
{
    class Theif : Character
    {
        public Theif(Character target, List<Client> users, List<Building> builded, int numDraws, int getCoins)
            : base(numDraws, getCoins)
        {
            ability(target, users);    
        }

        public void ability(Character target, List<Client> users)
        {
            foreach(Client clients in users)
            {
                if (clients.UserChar.Equals(target))
                {

                }
            }

        }
    }
}
