using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    internal class MultipleQuestionClass : QuestionClass
    {
        public List<int> CorrectAnswersIndexes { get; set; }
        public List<int> SelectedAnswersIndexes { get; set; } = new List<int>();

        public MultipleQuestionClass(int number, string question, string[] answers, List<int> correctAnswersIndexes)
        {
            Number = number;
            Question = question;
            Answers = answers;
            CorrectAnswersIndexes = correctAnswersIndexes;
        }
    }
}
