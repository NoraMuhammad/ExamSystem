using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    abstract class Exam
    {
        protected string _ExamPath;
        protected QuestionList<TrueFalse_Q> TF_ExamQuestions;
        protected QuestionList<ChooseOne_Q> CHO_ExamQuestions;
        protected QuestionList<ChooseAll_Q> CHA_ExamQuestions;
        protected AnswerList ExamAnswers;
        public Exam()
        {
            TF_ExamQuestions = new QuestionList<TrueFalse_Q>();
            CHO_ExamQuestions = new QuestionList<ChooseOne_Q>();
            CHA_ExamQuestions = new QuestionList<ChooseAll_Q>();
            ExamAnswers = new AnswerList();
        }
        public abstract void StartExam();
        public abstract void CheckAnswersOfExam();
    }
}
