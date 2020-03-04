using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Cave
    {
        private GameObject _GameObject;

        private int[] adjacents1 = { 25, 26, 2, 7, 6, 30 };

        private int[] paths1 = { 25, 0, 0, 7, 6, 0};

        public Cave(GameObject gameObject)
        {
            _GameObject = gameObject;
        }

        public int[] GetAdjacent(int room)
        {
            return adjacents1;
        }

        public int[] GetDoors(int room)
        {
            return paths1;
        }

        public int GetNextRoom(int room, int direction)
        {
            return paths1[direction];
        }
    }
}
