using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quiz
{
    public partial class Form_multiple_questions : Form
    {
        private System.Windows.Forms.CheckBox[] checkBoxes;
        private MultipleQuestionClass? currentQuestion;
        public Form_multiple_questions()
        {
            InitializeComponent();

            checkBoxes = new System.Windows.Forms.CheckBox[] {
                checkBox_answer1,
                checkBox_answer2,
                checkBox_answer3,
                checkBox_answer4,
                checkBox_answer5,
                checkBox_answer6,
                checkBox_answer7,
                checkBox_answer8
            };
        }

        internal void LoadQuestion(MultipleQuestionClass question)
        {
            currentQuestion = question;
            if (question.Number == 1)
            {
                Program.QuizTimer.Start();
                button_previous.Hide();
            }

            this.Text = "Pytanie nr. " + question.Number.ToString();
            label_question.Text = question.Question;

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (i < question?.Answers?.Length)
                {
                    checkBoxes[i].Text = question.Answers[i];
                    checkBoxes[i].Visible = true;
                    checkBoxes[i].Checked = false;

                    if (question.CorrectAnswersIndexes.Contains(i))
                    {
                        checkBoxes[i].Tag = 1;
                    }
                }
                else
                {
                    checkBoxes[i].Visible = false;
                }
            }

            if (this.currentQuestion.Number == Program.QuestionsList.Count())
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
            currentQuestion?.SelectedAnswersIndexes.Clear();
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    currentQuestion?.SelectedAnswersIndexes.Add(i);
                }
            }

            if (this.currentQuestion?.Number < Program.QuestionsList.Count())
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

        private void Form_multiple_questions_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Zamknięcie pytania spowoduje zamknięcie całej aplikacji. Czy na pewno chcesz wyjść?",
                "Ostrzeżenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
