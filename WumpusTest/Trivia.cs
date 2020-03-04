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
        private int questionsTotal;
        private int questionsCorrect;
        private int questionsNecessary;
        private int questionsDone;

        public Trivia(GameObject gameObject)
        {
            _GameObject = gameObject;
        }

        public void ReadQuestionsFromFile()
        {

        }

        public void StartTrivia(int questionsTotal, int questionsNecessary)
        {
            this.questionsTotal = questionsTotal;
            this.questionsNecessary = questionsNecessary;
            questionsCorrect = 0;
            questionsDone = 0;

            _GameObject.ShowNewQuestion();
        }

        public void AnswerTrivia(bool correct)
        {
            // needs to:
            // - add 1 to correct
            // - add 1 to done
            // - check if finished all questions
            // - if so, call end trivia
            // - else, show new question
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
