﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examination_System
{
    class Program
    {
        static void Main(string[] args)
        {
            FinalExam finalExam = new FinalExam("Final Exam/Questions/");
            finalExam.StartExam();
            //finalExam.CheckAnswersOfExam();

            Console.ReadKey();
        }
    }
}