using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class PracticalExam : Exam
    {
        PracticalExam(string practicalExamPath)
        {
            _ExamPath = practicalExamPath;
        }
        public override void CheckAnswersOfExam()
        {
            throw new NotImplementedException();
        }

        public override void StartExam()
        {
            throw new NotImplementedException();
        }
    }
}
