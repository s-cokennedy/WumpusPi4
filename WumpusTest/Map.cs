using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Map
    {
        //instance Variables
        private int WhichRoom;
        private Random gen;
        //Constructor
        public Map() {
            WhichRoom = NewRandomRoom();
            gen = new Random();
        }
        //Accessors
        public int GetRoom() {
            return WhichRoom;
        }
        public int GetWumpusMovement(int caves, Random gen) {
            int WumpusMov = gen.Next(caves); 
            return WumpusMov;
        }

        public int NewRandomRoom()
        {
            //TODO
            return 1;
        }
    }
}
