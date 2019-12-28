using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examination_System
{
    abstract class Question<TQuestion, TAnswer>
    {
        protected int _QNum;
        protected string _QHeader;
        protected string _QBody;
        protected float _QMarks;
        protected AnswerList Choices;
        public Question()
        {
            Choices = new AnswerList();
        }
        public abstract TQuestion readQuestionFromFile(string QFileName, string QChoicesFileName);
        public abstract bool checkQuestionAnswer(TAnswer answer);
        public float getQuestionMarks() => _QMarks;
        public abstract void printQuestionNoAnswer();
        public override string ToString()
        {
            return $"{_QNum}) {_QBody}   {_QMarks}";
        }
    }
}
