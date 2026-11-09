using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    internal class SingleQuestionClass : QuestionClass
    {
        public int CorrectAnswerIndex { get; set; }

        public SingleQuestionClass(int number, string question, string[] answers, int correctAnswerIndex)
        {
            Number = number;
            Question = question;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
