using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class Answer
    {
        protected char _ansLetter;
        protected string _ansBody;

        public char AnswerLetter { get { return _ansLetter; } set { _ansLetter = value; } }
        public string AnswerBody { get { return _ansBody; } set { _ansBody = value; } }

        public Answer setAnswer(string answer)
        {
            string[] myAns = answer.Split(')');
            if (myAns.Length == 1)
                return new Answer() { _ansLetter = answer.ToCharArray()[0] };
            else
                return new Answer() { _ansLetter = myAns[0].ToCharArray()[0], _ansBody = myAns[1] };
        }
        public override string ToString()
        {
            return $"{_ansLetter}) {_ansBody}";
        }
    }
}
