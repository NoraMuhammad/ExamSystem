using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class AnswerList:Answer
    {
        List<Answer> AnswersList;
        public int Length
        {
            get
            {
                return AnswersList.Count;
            }
        }
        public AnswerList()
        {
            AnswersList = new List<Answer>();
        }
        public Answer GetAnswerAtIndex(int index)
        {
            return AnswersList[index];
        }
        public List<Answer> setAnswers(string answers)
        {
            string[] myAnswers = answers.Split('#');
            for(int i = 0; i < myAnswers.Length; i++)
            {
                AnswersList.Add(setAnswer(myAnswers[i]));
            }
            return AnswersList;
        }
        public void AddAnswer(string ans)
        {
            Answer a = new Answer().setAnswer(ans);
            AnswersList.Add(a);
        }
        public override string ToString()
        {
            string returnStr = "";
            for(int i = 0; i < AnswersList.Count; i++)
            {
                returnStr += $"{AnswersList[i].ToString()}\n";
            }
            return returnStr;
        }
    }
}
