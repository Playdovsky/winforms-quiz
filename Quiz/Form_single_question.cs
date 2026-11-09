using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form_single_question : Form
    {

        private RadioButton[] radioButtons;
        private QuestionClass currentQuestion;

        public Form_single_question()
        {
            InitializeComponent();

            radioButtons = new RadioButton[]
            {
                radioButton_answer1,
                radioButton_answer2,
                radioButton_answer3,
                radioButton_answer4,
                radioButton_answer5,
                radioButton_answer6,
                radioButton_answer7,
                radioButton_answer8
            };
        }

        internal void LoadQuestion(SingleQuestionClass question)
        {
            currentQuestion = question;
            if (question.Number == 1)
            {
                button_previous.Hide();
            }

            this.Text = "Pytanie nr. " + question.Number.ToString();
            label_question.Text = question.Question;

            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (i < question?.Answers?.Length)
                {
                    radioButtons[i].Text = question.Answers[i];
                    radioButtons[i].Visible = true;
                    radioButtons[i].Checked = false;

                    if (i == question.CorrectAnswerIndex)
                    {
                        radioButtons[i].Tag = 1;
                    }
                }
                else
                {
                    radioButtons[i].Visible = false;
                }
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            Program.QuestionForms[currentQuestion.Number - 2].Show();
            this.Hide();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Checked && rb.Tag?.ToString() == "1")
                {
                    currentQuestion.IsGoodAnswerSelected = true;
                    MessageBox.Show("Poprawna odpowiedź, jupiii!");
                }
            }

            if (this.currentQuestion.Number < Program.SingleQuestionsList.Count())
            {
                Program.QuestionForms[currentQuestion.Number].Show();
                this.Hide();
            }
        }

        private void Form_single_question_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Zamknięcie pytania spowoduje zamknięcie całej aplikacji. Czy na pewno chcesz wyjść?",
                "Ostrzeżenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
