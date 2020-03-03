using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Player
    {
        // Instance Variables
        private int NumberofTriviaQuestionsCorrect;
        private int Number_of_minigames_Won;

        private int amountOfGold;
        // Constructors
        public Player()
        {
            NumberofTriviaQuestionsCorrect = 0;
            Number_of_minigames_Won = 0;
            amountOfGold = 0;
        }
        //Accesors
        public int[] GetInventory()
        {
            int[] Inventory = new int[5];
            return Inventory;
        }
        public int GetArrows(int NumberofTriviaQuestionsCorrect)
        {
            int arrows = NumberofTriviaQuestionsCorrect;
            return arrows;
        }
        public int GetScore(int Number_of_minigames_Won, int NumberofTriviaQuestionsCorrect)
        {
            int Score = NumberofTriviaQuestionsCorrect + Number_of_minigames_Won;
            return Score;
        }

        public void AddGold(int amount)
        {
            // add gold to the player
        }

        public bool RemoveGold(int amount)
        {
            // remove gold from the player
            // if not enough gold, return false
            return true;
        }

        public void AddArrows(int amount)
        {
            // add arrows
        }

    }
}
