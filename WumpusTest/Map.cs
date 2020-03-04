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
        private GameObject _GameObject;
        //Constructor
        public Map(GameObject gameObject) {
            WhichRoom = NewRandomRoom();
            gen = new Random();
            _GameObject = gameObject;
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

        public void MovePlayerTo(int newLocation)
        {
            // move player to the new location
            // needs to check for hazards, too
        }
    }
}
