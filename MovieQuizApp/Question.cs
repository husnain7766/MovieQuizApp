using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieQuizApp
{
    class Question
    {
        private string _description;
        private string _question;
        private char _type;
        private string _option1;
        private string _option2;
        private string _option3;
        private string _option4;
        private int _correctOption;

        public Question(string description, string question, char type, string option1, string option2, string option3, string option4, int correctOption)
        {
            _description = description;
            _question = question;
            _type = type;
            _option1 = option1;
            _option2 = option2;
            _option3 = option3;
            _option4 = option4;
            _correctOption = correctOption;
        }

        public Question(string line)
        {
            FromLine(line);
        }

        public void FromLine(string line)
        {
            string[] splits = line.Split(';');
            _type = splits[0][0];
            if (_type == 'M')
            {
                _description = splits[1];
                _question = splits[2];
                string[] options = splits[3].Split('/');
                _option1 = options[0];
                _option2 = options[1];
                _option3 = options[2];
                _option4 = options[3];
                _correctOption = int.Parse(splits[4]);
            }
            else if (_type == 'T')
            {

                _description = splits[1];
                _question = splits[2];
                _correctOption = int.Parse(splits[3]);
            }

        }


        public string ToLine()
        {
            if (_type == 'M')
            {
                return _type + ";" + _description + ";" + _question + ";" + _option1 + "/" + _option2 + "/" + _option3 +
                       "/" + _option4 + ";" + _correctOption;
            }
            else if(_type == 'T')
            {
                return _type + ";" + _description + ";" + _question + ";" + _correctOption;
            }
            return "";
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string Question1
        {
            get => _question;
            set => _question = value;
        }

        public char Type
        {
            get => _type;
            set => _type = value;
        }

        public string Option1
        {
            get => _option1;
            set => _option1 = value;
        }

        public string Option2
        {
            get => _option2;
            set => _option2 = value;
        }

        public string Option3
        {
            get => _option3;
            set => _option3 = value;
        }

        public string Option4
        {
            get => _option4;
            set => _option4 = value;
        }

        public int CorrectOption
        {
            get => _correctOption;
            set => _correctOption = value;
        }
    }
}
