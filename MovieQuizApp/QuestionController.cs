using System;
using System.Collections.Generic;
using System.IO;

namespace MovieQuizApp
{
    class QuestionController
    {
        public static QuestionController Instance = new QuestionController();
        private List<Question> _questionsList ;
        private int _questionTime;
        public string message = "";
        private QuestionController()
        {
            _questionTime = 2;
            _questionsList = new List<Question>();
        }

        public bool ReadAllQuestion(string questionFileName)
        {
            _questionsList.Clear();
            try
            {
                string[] lines = File.ReadAllLines(questionFileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    _questionsList.Add(new Question(lines[i]));
                }       

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public List<Question> QuestionsList
        {
            get => _questionsList;
            set => _questionsList = value;
        }

        public int QuestionTime
        {
            get => _questionTime;
            set => _questionTime = value;
        }

        public bool SaveAllQuestions(string questionFileName)
        {
            try
            {
                if (_questionsList != null)
                {
                    string[] lines = new string[_questionsList.Count];
                    for (int i = 0; i < _questionsList.Count; i++)
                    {
                        lines[i] = _questionsList[i].ToLine();
                    }
                    File.WriteAllLines(questionFileName,lines);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

            return true;
        }

    }
}
