using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examination_System
{
    class TrueFalse_Q:Question<TrueFalse_Q, Answer>
    {
        Answer _QRAns;

        public TrueFalse_Q()
        {
            _QRAns = new Answer();
            _QHeader = "True/False Statement:";
        }

        public override bool checkQuestionAnswer(Answer answer)
        {
            return _QRAns.AnswerLetter == answer.AnswerLetter;
        }

        public override void printQuestionNoAnswer()
        {
            Console.WriteLine(_QNum + "] " + _QBody + " (" + _QMarks + " Marks)\n" + Choices);
        }

        public override TrueFalse_Q readQuestionFromFile(string QFileName, string QChoicesFileName)
        {
            Console.Clear();
            Console.WriteLine(_QHeader);
            string[] myQuestion = File.ReadAllLines(QFileName);
            string[] QParts = myQuestion[0].Split('@');
            _QNum = int.Parse(QParts[0]);
            _QBody = QParts[1];
            _QMarks = float.Parse(QParts[2]);
            _QRAns = _QRAns.setAnswer(QParts[3]);

            string[] myChoices = File.ReadAllLines(QChoicesFileName);
            for (int i = 0; i < myChoices.Length; i++)
            {
                Choices.AddAnswer(myChoices[i]);
            }

            return this;
        }

        public override string ToString()
        {
            return $"{_QNum}] {_QBody}  ({_QMarks} Marks)\n{Choices}\nRight Answer: {_QRAns}\n";
        }
    }
}
