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
            CountCorrectAnswers();
            GenerateSummary();
        }

        public void CountCorrectAnswers()
        {
            int numberOfQuestions = Program.SingleQuestionsList.Count;
            int numberOfCorrectAnswers = 0;
            foreach (SingleQuestionClass question in Program.SingleQuestionsList)
            {
                if (question.SelectedAnswerIndex == question.CorrectAnswerIndex)
                {
                    numberOfCorrectAnswers++;
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

            foreach (SingleQuestionClass question in Program.SingleQuestionsList)
            {
                Label label_question = new Label();
                label_question.Width = flowLayoutPanel_answers_summary.Width - 30;
                label_question.AutoSize = true;

                bool isCorrect = false;

                if (question.SelectedAnswerIndex == question.CorrectAnswerIndex)
                {
                    isCorrect = true;
                }

                if (isCorrect)
                {
                    label_question.ForeColor = Color.Green;
                    label_question.Text = 
                        "Pytanie " + question.Number.ToString() + ": " + question.Question
                        + "\nTwoja odpowiedź: " + question.Answers?[question.SelectedAnswerIndex] + " (Poprawna!)\n\n";
                }
                else
                {
                    label_question.ForeColor = Color.Red;
                    string selectedAnswer = "Brak odpoweidzi";
                    
                    if (question.Answers?[question.SelectedAnswerIndex] != null)
                    {
                        selectedAnswer = question.Answers[question.SelectedAnswerIndex];
                    }

                    string correctAnswer = question.Answers[question.CorrectAnswerIndex];
                    
                    label_question.Text = 
                        "Pytanie " + question.Number.ToString() + ": " + question.Question
                        + "\nTwoja odpowiedź: " + selectedAnswer + " (Błędna)"
                        + "\nPoprawna odpowiedź: " + correctAnswer + "\n\n";
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
