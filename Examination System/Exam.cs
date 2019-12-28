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
        protected float ExamGrade;
        protected float ExamTotalMarks;
        protected List<Dictionary<Question<TrueFalse_Q, Answer>, Answer>> TF_ExamQuestions;
        protected List<Dictionary<Question<ChooseOne_Q, Answer>, Answer>> CHO_ExamQuestions;
        protected List<Dictionary<Question<ChooseAll_Q, AnswerList>, AnswerList>> CHA_ExamQuestions;

        public Exam()
        {
            ExamGrade = 0;
            ExamTotalMarks = 0;
            TF_ExamQuestions = new List<Dictionary<Question<TrueFalse_Q, Answer>, Answer>>();
            CHO_ExamQuestions = new List<Dictionary<Question<ChooseOne_Q, Answer>, Answer>>();
            CHA_ExamQuestions = new List<Dictionary<Question<ChooseAll_Q, AnswerList>, AnswerList>>();
        }
        public abstract void StartExam();
        public abstract void CheckAnswersOfExam();
        public abstract void ShowExamModelAnswer();
    }
}
