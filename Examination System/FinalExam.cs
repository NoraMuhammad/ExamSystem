using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    class FinalExam:Exam
    {
        public FinalExam(string finalExamPath)
        {
            _ExamPath = finalExamPath;
        }
        public override void CheckAnswersOfExam()
        {
            bool rightAns = false;
            Answer ans = new Answer();
            AnswerList ansList = new AnswerList();
            Question<TrueFalse_Q, Answer> TF = new TrueFalse_Q();
            Question<ChooseOne_Q, Answer> CHO = new ChooseOne_Q();
            Question<ChooseAll_Q, AnswerList> CHA = new ChooseAll_Q();

            for (int i = 0; i < TF_ExamQuestions.Count; i++)
            {
                TF = TF_ExamQuestions[i].Keys.ElementAt(i);
                ans = TF_ExamQuestions[i].Values.ElementAt(i);
                rightAns = TF.checkQuestionAnswer(ans);
                if (rightAns)
                    ExamGrade += TF.getQuestionMarks();
                ExamTotalMarks += TF.getQuestionMarks();
            }
            for (int i = 0; i < CHO_ExamQuestions.Count; i++)
            {
                CHO = CHO_ExamQuestions[i].Keys.ElementAt(i);
                ans = CHO_ExamQuestions[i].Values.ElementAt(i);
                rightAns = CHO.checkQuestionAnswer(ans);
                if (rightAns)
                    ExamGrade += CHO.getQuestionMarks();
                ExamTotalMarks += CHO.getQuestionMarks();
            }
            for (int i = 0; i < CHA_ExamQuestions.Count; i++)
            {
                CHA = CHA_ExamQuestions[i].Keys.ElementAt(i);
                ansList = CHA_ExamQuestions[i].Values.ElementAt(i);
                rightAns = CHA.checkQuestionAnswer(ansList);
                if (rightAns)
                    ExamGrade += CHA.getQuestionMarks();
                ExamTotalMarks += CHA.getQuestionMarks();
            }

            Console.Clear();
            Console.WriteLine($"Your Exam Grade is: {ExamGrade}/{ExamTotalMarks}");
            Console.WriteLine("Press Enter To show Exam Model Answer");
            Console.ReadKey();
            Console.WriteLine("Exam Model Answer is:");
            ShowExamModelAnswer();
        }
        public override void StartExam()
        {
            #region Needed Temp Variables
            int count = 0;
            Answer ans = new Answer();
            AnswerList ansList = new AnswerList();
            Question<TrueFalse_Q, Answer> TF = new TrueFalse_Q();
            Question<ChooseOne_Q, Answer> CHO = new ChooseOne_Q();
            Question<ChooseAll_Q, AnswerList> CHA = new ChooseAll_Q();
            Dictionary<Question<TrueFalse_Q, Answer>, Answer> TFTempDictionary = new Dictionary<Question<TrueFalse_Q, Answer>, Answer>();
            Dictionary<Question<ChooseOne_Q, Answer>, Answer> CHOTempDictionary = new Dictionary<Question<ChooseOne_Q, Answer>, Answer>();
            Dictionary<Question<ChooseAll_Q, AnswerList>, AnswerList> CHATempDictionary = new Dictionary<Question<ChooseAll_Q, AnswerList>, AnswerList>();
            #endregion

            TF.readQuestionFromFile($"{_ExamPath}Questions/TrueFalse1.txt", $"{_ExamPath}Choices/TrueFalse1_Choices.txt");
            TF.printQuestionNoAnswer();
            string userInput = Console.ReadLine();
            ans = new Answer().setAnswer(userInput);
            TFTempDictionary[TF] = ans;
            TF_ExamQuestions.Add(TFTempDictionary);

            TF = new TrueFalse_Q();
            TF.readQuestionFromFile($"{_ExamPath}Questions/TrueFalse2.txt", $"{_ExamPath}Choices/TrueFalse2_Choices.txt");
            TF.printQuestionNoAnswer();
            userInput = Console.ReadLine();
            ans = new Answer().setAnswer(userInput);
            TFTempDictionary[TF] = ans;
            TF_ExamQuestions.Add(TFTempDictionary);

            CHO = new ChooseOne_Q();
            CHO.readQuestionFromFile($"{_ExamPath}Questions/ChooseOne1.txt", $"{_ExamPath}Choices/ChooseOne1_Choices.txt");
            CHO.printQuestionNoAnswer();
            userInput = Console.ReadLine();
            ans = new Answer().setAnswer(userInput);
            CHOTempDictionary[CHO] = ans;
            CHO_ExamQuestions.Add(CHOTempDictionary);

            CHO = new ChooseOne_Q();
            CHO.readQuestionFromFile($"{_ExamPath}Questions/ChooseOne2.txt", $"{_ExamPath}Choices/ChooseOne2_Choices.txt");
            CHO.printQuestionNoAnswer();
            userInput = Console.ReadLine();
            ans = new Answer().setAnswer(userInput);
            CHOTempDictionary[CHO] = ans;
            CHO_ExamQuestions.Add(CHOTempDictionary);

            CHA = new ChooseAll_Q();
            CHA.readQuestionFromFile($"{_ExamPath}Questions/ChooseAll1.txt", $"{_ExamPath}Choices/ChooseAll1_Choices.txt");
            CHA.printQuestionNoAnswer();

            userInput = Console.ReadLine();
            while (userInput != "" && count < 4)
            {
                ansList.AddAnswer(userInput);
                count++;
                userInput = Console.ReadLine();
            }
            CHATempDictionary[CHA] = ansList;
            CHA_ExamQuestions.Add(CHATempDictionary);

            count = 0;
            CHA = new ChooseAll_Q();
            CHA.readQuestionFromFile($"{_ExamPath}Questions/ChooseAll2.txt", $"{_ExamPath}Choices/ChooseAll2_Choices.txt");
            CHA.printQuestionNoAnswer();

            userInput = Console.ReadLine();
            while (userInput != "" && count < 4)
            {
                ansList.AddAnswer(userInput);
                count++;
                userInput = Console.ReadLine();
            }
            CHATempDictionary[CHA] = ansList;
            CHA_ExamQuestions.Add(CHATempDictionary);

            CheckAnswersOfExam();
        }
        public override void ShowExamModelAnswer()
        {
            Console.Clear();
            for(int i = 0; i < TF_ExamQuestions.Count; i++)
            {
                Console.WriteLine(TF_ExamQuestions[i].Keys.ElementAt(i));
            }
            for (int i = 0; i < CHO_ExamQuestions.Count; i++)
            {
                Console.WriteLine(CHO_ExamQuestions[i].Keys.ElementAt(i));
            }
            for (int i = 0; i < CHA_ExamQuestions.Count; i++)
            {
                Console.WriteLine(CHA_ExamQuestions[i].Keys.ElementAt(i));
            }
        }
    }
}
