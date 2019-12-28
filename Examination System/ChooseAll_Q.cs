using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examination_System
{
    class ChooseAll_Q : Question<ChooseAll_Q, AnswerList>
    {
        AnswerList _QRAnswers;
        public ChooseAll_Q()
        {
            _QRAnswers = new AnswerList();
            _QHeader = "Choose ALL the right answers:";
        }
        public override bool checkQuestionAnswer(AnswerList answerList)
        {
            int count = 0;
            for(int i = 0; i < _QRAnswers.Length; i++)
            {
                for(int j = 0; j < answerList.Length; j++)
                {
                    if (answerList.GetAnswerAtIndex(j).AnswerLetter == _QRAnswers.GetAnswerAtIndex(i).AnswerLetter)
                        count++;
                }
            }
            if (count == answerList.Length)
                return true;
            return false;
        }
        public override void printQuestionNoAnswer()
        {
            Console.WriteLine(_QNum + "] " + _QBody + " (" + _QMarks + " Marks)\n" + Choices);
        }
        public override ChooseAll_Q readQuestionFromFile(string QFileName, string QChoicesFileName)
        {
            Console.Clear();
            Console.WriteLine(_QHeader);
            string[] myQuestion = File.ReadAllLines(QFileName);
            string[] QParts = myQuestion[0].Split('@');
            _QNum = int.Parse(QParts[0]);
            _QBody = QParts[1];
            _QMarks = float.Parse(QParts[2]);
            _QRAnswers.setAnswers(QParts[3]);

            string[] myChoices = File.ReadAllLines(QChoicesFileName);
            for (int i = 0; i < myChoices.Length; i++)
            {
                Choices.AddAnswer(myChoices[i]);
            }

            return this;
        }
        public override string ToString()
        {
            return $"{_QNum}] {_QBody}  ({_QMarks} Marks)\n{Choices}\nRight Answer/s: {_QRAnswers}\n";
        }
    }
}
