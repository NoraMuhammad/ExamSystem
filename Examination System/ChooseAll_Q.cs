using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examination_System
{
    class ChooseAll_Q : Question<ChooseAll_Q>
    {
        AnswerList _QRAnswers;
        public ChooseAll_Q()
        {
            _QRAnswers = new AnswerList();
        }
        public override void printQuestionNoAnswer()
        {
            Console.WriteLine(_QNum + "] " + _QBody + " (" + _QMarks + " Marks)");
        }

        public override void printQuestionWithAnswer()
        {
            Console.WriteLine(_QNum + "] " + _QBody + " (" + _QMarks + " Marks): " + _QRAnswers);
        }

        public override ChooseAll_Q readQuestionFromFile(string path)
        {
            string[] myQuestion = File.ReadAllLines(path);
            string[] QParts = myQuestion[0].Split('@');
            _QNum = int.Parse(QParts[0]);
            _QBody = QParts[1];
            _QMarks = float.Parse(QParts[2]);
            _QRAnswers.setAnswers(QParts[3]);

            return this;
        }
    }
}
