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
        private Trivia _Trivia;
        private UserInterface _UI;

        private string State;

        public GameObject()
        {
            _Cave = new Cave(this);
            _Map = new Map(this);
            _Player = new Player(this);
            _Trivia = new Trivia(this);
            _UI = new UserInterface(this);
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
            ShowNewQuestion();
        }

        public void EndTrivia()
        {
            State = "Playing";
        }

        public void ShowNewQuestion()
        {
            int questionId = _Trivia.GetRandomId();
            string question = _Trivia.GetQuestion(questionId);
            string[] answers = _Trivia.GetAnswers(questionId);
            _UI.DisplayTrivia(question, answers);
            _Trivia.SetCurrentId(questionId);
        }

        public void AnswerTrivia(string answer)
        {
            _Player.RemoveGold(1);
            int currentId = _Trivia.GetCurrentId();
            string correctAnswer = _Trivia.GetCorrectAnswer(currentId);

            if (answer.Equals(correctAnswer))
            {
                // do stuff
            }
            else
            {
                // do other stuff
            }
        }

    }
}
