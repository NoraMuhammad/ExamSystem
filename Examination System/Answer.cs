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

        public Answer setAnswer(string answer)
        {
            string[] myAns = answer.Split(')');
            return new Answer() { _ansLetter = myAns[0].ToCharArray()[0], _ansBody = myAns[1] };
        }
        public override string ToString()
        {
            return $"{_ansLetter}) {_ansBody}";
        }
    }
}
