using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examination_System
{
    abstract class Question<T>
    {
        protected int _QNum;
        protected string _QBody;
        protected float _QMarks;
        protected AnswerList Choices;
        public Question()
        {
            Choices = new AnswerList();
        }
        public abstract T readQuestionFromFile(string path);
        public abstract void printQuestionNoAnswer();
        public abstract void printQuestionWithAnswer();
        public override string ToString()
        {
            return $"{_QNum}) {_QBody}   {_QMarks}";
        }
    }
}
