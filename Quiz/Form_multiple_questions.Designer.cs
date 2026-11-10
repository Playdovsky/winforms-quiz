namespace Quiz
{
    partial class Form_multiple_questions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_previous = new Button();
            button_next = new Button();
            label_question = new Label();
            checkBox_answer1 = new CheckBox();
            checkBox_answer2 = new CheckBox();
            checkBox_answer3 = new CheckBox();
            checkBox_answer4 = new CheckBox();
            checkBox_answer5 = new CheckBox();
            checkBox_answer6 = new CheckBox();
            checkBox_answer7 = new CheckBox();
            checkBox_answer8 = new CheckBox();
            SuspendLayout();
            // 
            // button_previous
            // 
            button_previous.Location = new Point(12, 303);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(131, 23);
            button_previous.TabIndex = 10;
            button_previous.Text = "Poprzednie pytanie";
            button_previous.UseVisualStyleBackColor = true;
            button_previous.Click += button_previous_Click;
            // 
            // button_next
            // 
            button_next.Location = new Point(556, 303);
            button_next.Name = "button_next";
            button_next.Size = new Size(131, 23);
            button_next.TabIndex = 11;
            button_next.Text = "Następne pytanie";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // label_question
            // 
            label_question.AutoSize = true;
            label_question.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_question.Location = new Point(12, 9);
            label_question.Name = "label_question";
            label_question.Size = new Size(60, 20);
            label_question.TabIndex = 12;
            label_question.Text = "Pytanie";
            // 
            // checkBox_answer1
            // 
            checkBox_answer1.AutoSize = true;
            checkBox_answer1.Location = new Point(12, 75);
            checkBox_answer1.Name = "checkBox_answer1";
            checkBox_answer1.Size = new Size(92, 19);
            checkBox_answer1.TabIndex = 13;
            checkBox_answer1.Tag = "0";
            checkBox_answer1.Text = "Odpowiedz1";
            checkBox_answer1.UseVisualStyleBackColor = true;
            // 
            // checkBox_answer2
            // 
            checkBox_answer2.AutoSize = true;
            checkBox_answer2.Location = new Point(12, 100);
            checkBox_answer2.Name = "checkBox_answer2";
            checkBox_answer2.Size = new Size(92, 19);
            checkBox_answer2.TabIndex = 14;
            checkBox_answer2.Tag = "0";
            checkBox_answer2.Text = "Odpowiedz2";
            checkBox_answer2.UseVisualStyleBackColor = true;
            // 
            // checkBox_answer3
            // 
            checkBox_answer3.AutoSize = true;
            checkBox_answer3.Location = new Point(12, 125);
            checkBox_answer3.Name = "checkBox_answer3";
            checkBox_answer3.Size = new Size(92, 19);
            checkBox_answer3.TabIndex = 15;
            checkBox_answer3.Tag = "0";
            checkBox_answer3.Text = "Odpowiedz3";
            checkBox_answer3.UseVisualStyleBackColor = true;
            // 
            // checkBox_answer4
            // 
            checkBox_answer4.AutoSize = true;
            checkBox_answer4.Location = new Point(12, 150);
            checkBox_answer4.Name = "checkBox_answer4";
            checkBox_answer4.Size = new Size(92, 19);
            checkBox_answer4.TabIndex = 16;
            checkBox_answer4.Tag = "0";
            checkBox_answer4.Text = "Odpowiedz4";
            checkBox_answer4.UseVisualStyleBackColor = true;
            // 
            // checkBox_answer5
            // 
            checkBox_answer5.AutoSize = true;
            checkBox_answer5.Location = new Point(12, 175);
            checkBox_answer5.Name = "checkBox_answer5";
            checkBox_answer5.Size = new Size(92, 19);
            checkBox_answer5.TabIndex = 17;
            checkBox_answer5.Tag = "0";
            checkBox_answer5.Text = "Odpowiedz5";
            checkBox_answer5.UseVisualStyleBackColor = true;
            // 
            // checkBox_answer6
            // 
            checkBox_answer6.AutoSize = true;
            checkBox_answer6.Location = new Point(12, 200);
            checkBox_answer6.Name = "checkBox_answer6";
            checkBox_answer6.Size = new Size(92, 19);
            checkBox_answer6.TabIndex = 18;
            checkBox_answer6.Tag = "0";
            checkBox_answer6.Text = "Odpowiedz6";
            checkBox_answer6.UseVisualStyleBackColor = true;
            // 
            // checkBox_answer7
            // 
            checkBox_answer7.AutoSize = true;
            checkBox_answer7.Location = new Point(12, 225);
            checkBox_answer7.Name = "checkBox_answer7";
            checkBox_answer7.Size = new Size(92, 19);
            checkBox_answer7.TabIndex = 19;
            checkBox_answer7.Tag = "0";
            checkBox_answer7.Text = "Odpowiedz7";
            checkBox_answer7.UseVisualStyleBackColor = true;
            // 
            // checkBox_answer8
            // 
            checkBox_answer8.AutoSize = true;
            checkBox_answer8.Location = new Point(12, 250);
            checkBox_answer8.Name = "checkBox_answer8";
            checkBox_answer8.Size = new Size(92, 19);
            checkBox_answer8.TabIndex = 20;
            checkBox_answer8.Tag = "0";
            checkBox_answer8.Text = "Odpowiedz8";
            checkBox_answer8.UseVisualStyleBackColor = true;
            // 
            // Form_multiple_questions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 338);
            Controls.Add(checkBox_answer8);
            Controls.Add(checkBox_answer7);
            Controls.Add(checkBox_answer6);
            Controls.Add(checkBox_answer5);
            Controls.Add(checkBox_answer4);
            Controls.Add(checkBox_answer3);
            Controls.Add(checkBox_answer2);
            Controls.Add(checkBox_answer1);
            Controls.Add(label_question);
            Controls.Add(button_next);
            Controls.Add(button_previous);
            Name = "Form_multiple_questions";
            Text = "Form_multiple_questions";
            FormClosing += Form_multiple_questions_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_previous;
        private Button button_next;
        internal Label label_question;
        private CheckBox checkBox_answer1;
        private CheckBox checkBox_answer2;
        private CheckBox checkBox_answer3;
        private CheckBox checkBox_answer4;
        private CheckBox checkBox_answer5;
        private CheckBox checkBox_answer6;
        private CheckBox checkBox_answer7;
        private CheckBox checkBox_answer8;
    }
}