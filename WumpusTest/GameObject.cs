using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class GameObject
    {
        private Map _Map;
        private Cave _Cave;
        private Player _Player;

        private String State;

        public GameObject()
        {
            _Cave = new Cave();
            _Map = new Map();
            _Player = new Player();
            State = "Not Started";
        }

        public void MoveForward(int direction)
        {
            int currentRoom = _Map.GetRoom();
            int nextRoom = _Cave.GetNextRoom(currentRoom, direction);
            if (nextRoom != 0)
            {
                _Player.AddGold(1);
            }
            else
            {
                // can't move that way
            }
        }

        public void StartGame()
        {
            // create new cave
            // move player to new location
            // create the obstacles
            State = "Playing";
        }

        public void SeeHighScores()
        {
            State = "Viewing High Scores";
        }

        public void BuyArrows()
        {
            //TODO: ask trivia for questions and display them
            bool success = true;
            if (success)
            {
                _Player.AddArrows(5);
            }
        }

        public void EndGame()
        {
            State = "Ended";
        }

        public void StartTrivia()
        {
            State = "Trivia";
        }

        public void EndTrivia()
        {
            State = "Playing";
        }

        public void AnswerTrivia()
        {
            _Player.RemoveGold(1);
        }

    }
}
