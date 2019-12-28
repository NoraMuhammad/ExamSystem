using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examination_System
{
    class QuestionList<TQuestion, TAnswer>
    {
        List<Question<TQuestion, TAnswer>> _questionList;

        public QuestionList()
        {
            _questionList = new List<Question<TQuestion, TAnswer>>();
        }
        public void AddToList(Question<TQuestion, TAnswer> Q)
        {
            _questionList.Add(Q);
        }
        public override string ToString()
        {
            string returnStr = "";
            for (int i = 0; i < _questionList.Count; i++)
            {
                returnStr += $"{_questionList[i].ToString()}\n";
            }
            return returnStr;
        }
    }
}
