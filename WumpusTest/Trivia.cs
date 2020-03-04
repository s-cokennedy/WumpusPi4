using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Trivia
    {
        private GameObject _GameObject;

        private int currentId;

        public Trivia(GameObject gameObject)
        {
            _GameObject = gameObject;
        }

        public void ReadQuestionsFromFile()
        {

        }

        // how I think questions will work:
        // each question has an id
        // the id allows the other objects to get questions and answers separately

        public int GetRandomId()
        {
            return 0;
        }

        public string GetQuestion(int id)
        {
            return "What is 1 + 1?";
        }

        public string[] GetAnswers(int id)
        {
            string[] answers = { "1", "2", "3", "4" };
            return answers;
        }
        
        public string GetCorrectAnswer(int id)
        {
            return "2";
        }

        public void SetCurrentId(int id)
        {
            currentId = id;
        }

        public int GetCurrentId()
        {
            return currentId;
        }
    }
}
