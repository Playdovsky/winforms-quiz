using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    internal abstract class QuestionClass
    {
        protected internal int Number { get; set; }
        protected internal string? Question { get; set; }
        protected internal string[]? Answers { get; set; }
        protected internal bool isCorrect = false;
    }
}
