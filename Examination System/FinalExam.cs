using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class FinalExam:Exam
    {
        public FinalExam(string finalExamPath)
        {
            _ExamPath = finalExamPath;
        }

        public override void CheckAnswersOfExam()
        {
            throw new NotImplementedException();
        }

        public override void StartExam()
        {
            Question<TrueFalse_Q> TF = new TrueFalse_Q();
            TF.readQuestionFromFile(_ExamPath +  "TrueFalse1.txt");
            TF.printQuestionNoAnswer();
            string userInput = Console.ReadLine();
            ExamAnswers.AddAnswer(userInput);

            TF = new TrueFalse_Q();
            TF.readQuestionFromFile(_ExamPath + "TrueFalse2.txt");
            TF.printQuestionNoAnswer();
            userInput = Console.ReadLine();
            ExamAnswers.AddAnswer(userInput);


        }
    }
}
