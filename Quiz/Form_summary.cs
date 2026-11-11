using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form_summary : Form
    {
        public Form_summary()
        {
            InitializeComponent();
            Program.QuizTimer.Stop();
            CountCorrectAnswers();
            GenerateSummary();

            this.Icon = new Icon("Flag_of_Romania.ico");
            TimeSpan elapsed = Program.QuizTimer.Elapsed;
            label_timer.Text = $"Quiz zakończony w {elapsed.Minutes} min, {elapsed.Seconds} sek";
        }

        public void CountCorrectAnswers()
        {
            int numberOfQuestions = Program.QuestionsList.Count;
            int numberOfCorrectAnswers = 0;
            foreach (QuestionClass question in Program.QuestionsList)
            {
                if (question is SingleQuestionClass singleQuestion)
                {
                    if (singleQuestion.SelectedAnswerIndex == singleQuestion.CorrectAnswerIndex)
                    {
                        numberOfCorrectAnswers++;
                        singleQuestion.isCorrect = true;
                    }
                }
                else if (question is MultipleQuestionClass multipleQuestion)
                {
                    var sortedSelectedAnswers = multipleQuestion.SelectedAnswersIndexes.OrderBy(x => x);
                    var sortedCorrectAnswers = multipleQuestion.CorrectAnswersIndexes.OrderBy(x => x);

                    if (sortedSelectedAnswers.SequenceEqual(sortedCorrectAnswers))
                    {
                        numberOfCorrectAnswers++;
                        multipleQuestion.isCorrect = true;
                    }
                }
            }

            if (numberOfCorrectAnswers > (numberOfQuestions / 2))
            {
                label_subtitle.ForeColor = Color.Green;
            }
            else if (numberOfCorrectAnswers == (numberOfQuestions / 2))
            {
                label_subtitle.ForeColor = Color.Yellow;
            }
            else
            {
                label_subtitle.ForeColor = Color.Red;
            }

            label_subtitle.Text = "Wynik: " + numberOfCorrectAnswers.ToString() + "/" + numberOfQuestions.ToString();
        }

        private void GenerateSummary()
        {
            flowLayoutPanel_answers_summary.Controls.Clear();

            foreach (QuestionClass question in Program.QuestionsList)
            {
                Label label_question = new Label();
                label_question.AutoSize = true;

                string selectedAnswerText = "Brak odpowiedzi";
                string correctAnswerText = "";

                if (question is SingleQuestionClass singleQuestion)
                {
                    if (singleQuestion.SelectedAnswerIndex >= 0 && singleQuestion.Answers != null)
                    {
                        selectedAnswerText = singleQuestion.Answers[singleQuestion.SelectedAnswerIndex];
                    }

                    correctAnswerText = singleQuestion.Answers[singleQuestion.CorrectAnswerIndex];
                }
                else if (question is MultipleQuestionClass multipleQuestion)
                {
                    if (multipleQuestion.SelectedAnswersIndexes != null && multipleQuestion.SelectedAnswersIndexes.Count > 0)
                    {
                        selectedAnswerText = string.Join("\n", multipleQuestion.SelectedAnswersIndexes.OrderBy(i => i).Select(i => multipleQuestion.Answers?[i]));
                    }

                    if (multipleQuestion.CorrectAnswersIndexes != null)
                    {
                        correctAnswerText = string.Join("\n", multipleQuestion.CorrectAnswersIndexes.OrderBy(i => i).Select(i => multipleQuestion.Answers?[i]));
                    }
                }

                if (question.isCorrect)
                {
                    label_question.ForeColor = Color.Green;
                    label_question.Text = 
                        $"Pytanie {question.Number}: {question.Question}\n\n" +
                        $"Zaznaczono:\n{selectedAnswerText} (Poprawnie!)" +
                        "\n\n_______________________________________________________________________\n\n";
                }
                else
                {
                    label_question.ForeColor = Color.Red;
                    label_question.Text = 
                        $"Pytanie {question.Number}: {question.Question}\n\n" +
                        $"Zaznaczono:\n{selectedAnswerText} (Błędnie)\n\n" +
                        $"Poprawne odpowiedzi:\n{correctAnswerText}" +
                        "\n\n_______________________________________________________________________\n\n";
                }

                flowLayoutPanel_answers_summary.Controls.Add(label_question);
            }
        }

        private void Form_summary_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
