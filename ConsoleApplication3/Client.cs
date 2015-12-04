using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication3
{
    class Client
    {
        private string userName;
        private TcpClient TCPclient;
        private Character userChar;     //
        private int userCoins;              
        private List<Building> builded;
        private List<Building> buildingCard;
        private bool hasCrown;
        private int userStatus;
        private bool isMyTurn;

        public Character UserChar
        {
            get
            {
                return userChar;
            }
            set
            {
                userChar=value;
            }
        }

        public bool IsMyTurn
        {
            get
            {
                return isMyTurn;
            }
            set
            {
                isMyTurn = !isMyTurn;
            }
        }

        public int UserStatus
        {
            get
            {
                return userStatus;
            }
            set
            {
                userStatus = value;
            }
        }

        public bool HasCrown
        {
            get
            {
                return hasCrown;
            }
            set
            {
                hasCrown = !hasCrown;
            }
        }

        public int UserCoins
        {
            get
            {
                return userCoins;
            }
            set
            {
                userCoins = userCoins + value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value; //string도 =으로 되나?
            }
        }

        public List<Building> Builded
        {
            get
            {
                return builded;
            }
            set
            {
                builded = value;        //list에 추가만 하고 싶었는데 시무룩
            }
        }

        public List<Building> BuildingCard
        {
            get;
            set;
        }
    }
}
