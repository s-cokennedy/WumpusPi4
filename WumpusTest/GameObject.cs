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
        private string TriviaResult;

        public GameObject()
        {
            _Cave = new Cave(this);
            _Map = new Map(this);
            _Player = new Player(this);
            _Trivia = new Trivia(this);
            _UI = new UserInterface(this);
            State = "Not Started";

            _Trivia.ReadQuestionsFromFile();
        }

        public void MoveForward(int direction)
        {
            int currentRoom = _Map.GetRoom();
            int nextRoom = _Cave.GetNextRoom(currentRoom, direction);
            if (nextRoom != 0)
            {
                _Player.AddGold(1);
                _Map.MovePlayerTo(nextRoom);
            }
        }

        public void StartGame()
        {
            // create new cave
            // move player to new location
            // create the obstacles
            State = "Playing";
        }

        public void EndGame()
        {
            State = "Ended";
        }

        public void SeeHighScores()
        {
            State = "Viewing High Scores";
        }

        public void FinishArrowTrivia()
        {
            _Player.AddArrows(5);
        }

        public void StartTrivia(int questionsTotal, int questionsNecessary, string result)
        {
            State = "Trivia";
            TriviaResult = result;
            _Trivia.StartTrivia(questionsTotal, questionsNecessary);
        }

        public void EndTrivia(bool success)
        {
            if (success)
            {
                if (TriviaResult.Equals("arrows"))
                {
                    FinishArrowTrivia();
                }
                // do other stuff
            }
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
                _Trivia.AnswerTrivia(true);
            }
            else
            {
                _Trivia.AnswerTrivia(false);
            }
        }

    }
}
