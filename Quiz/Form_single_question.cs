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
        private SingleQuestionClass? currentQuestion;

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

            if (this.currentQuestion.Number == Program.SingleQuestionsList.Count())
            {
                button_next.Text = "Zakończ";
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            Program.QuestionForms[currentQuestion.Number - 2].Show();
            this.Hide();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                {
                    currentQuestion?.SelectedAnswerIndex = i;
                    break;
                }
            }

            if (this.currentQuestion?.Number < Program.SingleQuestionsList.Count())
            {
                Program.QuestionForms[currentQuestion.Number].Show();
                this.Hide();
            }
            else
            {
                var result = MessageBox.Show("To było ostatnie pytanie, jeżeli zakończysz teraz twoje odpowiedzi zostaną zatwierdzone i nie będą już mogły zostać zmienione. Czy na pewno chcesz zakończyć quiz?",
                "Informacja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    Form summaryForm = new Form_summary();
                    summaryForm.Show();
                    this.Hide();
                }
                else
                {
                    return;
                }
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
