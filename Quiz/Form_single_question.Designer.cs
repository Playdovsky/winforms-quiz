namespace Quiz
{
    partial class Form_single_question
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
            label_question = new Label();
            radioButton_answer1 = new RadioButton();
            radioButton_answer2 = new RadioButton();
            radioButton_answer3 = new RadioButton();
            radioButton_answer4 = new RadioButton();
            radioButton_answer5 = new RadioButton();
            radioButton_answer6 = new RadioButton();
            radioButton_answer7 = new RadioButton();
            radioButton_answer8 = new RadioButton();
            button_previous = new Button();
            button_next = new Button();
            SuspendLayout();
            // 
            // label_question
            // 
            label_question.AutoSize = true;
            label_question.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_question.Location = new Point(12, 9);
            label_question.Name = "label_question";
            label_question.Size = new Size(61, 21);
            label_question.TabIndex = 0;
            label_question.Text = "Pytanie";
            // 
            // radioButton_answer1
            // 
            radioButton_answer1.AutoSize = true;
            radioButton_answer1.Location = new Point(12, 74);
            radioButton_answer1.Name = "radioButton_answer1";
            radioButton_answer1.Size = new Size(91, 19);
            radioButton_answer1.TabIndex = 1;
            radioButton_answer1.TabStop = true;
            radioButton_answer1.Tag = "0";
            radioButton_answer1.Text = "Odpowiedz1";
            radioButton_answer1.UseVisualStyleBackColor = true;
            // 
            // radioButton_answer2
            // 
            radioButton_answer2.AutoSize = true;
            radioButton_answer2.Location = new Point(12, 99);
            radioButton_answer2.Name = "radioButton_answer2";
            radioButton_answer2.Size = new Size(91, 19);
            radioButton_answer2.TabIndex = 2;
            radioButton_answer2.TabStop = true;
            radioButton_answer2.Tag = "0";
            radioButton_answer2.Text = "Odpowiedz2";
            radioButton_answer2.UseVisualStyleBackColor = true;
            // 
            // radioButton_answer3
            // 
            radioButton_answer3.AutoSize = true;
            radioButton_answer3.Location = new Point(12, 124);
            radioButton_answer3.Name = "radioButton_answer3";
            radioButton_answer3.Size = new Size(91, 19);
            radioButton_answer3.TabIndex = 3;
            radioButton_answer3.TabStop = true;
            radioButton_answer3.Tag = "0";
            radioButton_answer3.Text = "Odpowiedz3";
            radioButton_answer3.UseVisualStyleBackColor = true;
            // 
            // radioButton_answer4
            // 
            radioButton_answer4.AutoSize = true;
            radioButton_answer4.Location = new Point(12, 149);
            radioButton_answer4.Name = "radioButton_answer4";
            radioButton_answer4.Size = new Size(91, 19);
            radioButton_answer4.TabIndex = 4;
            radioButton_answer4.TabStop = true;
            radioButton_answer4.Tag = "0";
            radioButton_answer4.Text = "Odpowiedz4";
            radioButton_answer4.UseVisualStyleBackColor = true;
            radioButton_answer4.Visible = false;
            // 
            // radioButton_answer5
            // 
            radioButton_answer5.AutoSize = true;
            radioButton_answer5.Location = new Point(12, 174);
            radioButton_answer5.Name = "radioButton_answer5";
            radioButton_answer5.Size = new Size(91, 19);
            radioButton_answer5.TabIndex = 5;
            radioButton_answer5.TabStop = true;
            radioButton_answer5.Tag = "0";
            radioButton_answer5.Text = "Odpowiedz5";
            radioButton_answer5.UseVisualStyleBackColor = true;
            radioButton_answer5.Visible = false;
            // 
            // radioButton_answer6
            // 
            radioButton_answer6.AutoSize = true;
            radioButton_answer6.Location = new Point(12, 199);
            radioButton_answer6.Name = "radioButton_answer6";
            radioButton_answer6.Size = new Size(91, 19);
            radioButton_answer6.TabIndex = 6;
            radioButton_answer6.TabStop = true;
            radioButton_answer6.Tag = "0";
            radioButton_answer6.Text = "Odpowiedz6";
            radioButton_answer6.UseVisualStyleBackColor = true;
            radioButton_answer6.Visible = false;
            // 
            // radioButton_answer7
            // 
            radioButton_answer7.AutoSize = true;
            radioButton_answer7.Location = new Point(12, 224);
            radioButton_answer7.Name = "radioButton_answer7";
            radioButton_answer7.Size = new Size(91, 19);
            radioButton_answer7.TabIndex = 7;
            radioButton_answer7.TabStop = true;
            radioButton_answer7.Tag = "0";
            radioButton_answer7.Text = "Odpowiedz7";
            radioButton_answer7.UseVisualStyleBackColor = true;
            radioButton_answer7.Visible = false;
            // 
            // radioButton_answer8
            // 
            radioButton_answer8.AutoSize = true;
            radioButton_answer8.Location = new Point(12, 249);
            radioButton_answer8.Name = "radioButton_answer8";
            radioButton_answer8.Size = new Size(91, 19);
            radioButton_answer8.TabIndex = 8;
            radioButton_answer8.TabStop = true;
            radioButton_answer8.Tag = "0";
            radioButton_answer8.Text = "Odpowiedz8";
            radioButton_answer8.UseVisualStyleBackColor = true;
            radioButton_answer8.Visible = false;
            // 
            // button_previous
            // 
            button_previous.Location = new Point(12, 303);
            button_previous.Name = "button_previous";
            button_previous.Size = new Size(131, 23);
            button_previous.TabIndex = 9;
            button_previous.Text = "Poprzednie pytanie";
            button_previous.UseVisualStyleBackColor = true;
            button_previous.Click += button_previous_Click;
            // 
            // button_next
            // 
            button_next.Location = new Point(155, 303);
            button_next.Name = "button_next";
            button_next.Size = new Size(131, 23);
            button_next.TabIndex = 10;
            button_next.Text = "Następne pytanie";
            button_next.UseVisualStyleBackColor = true;
            button_next.Click += button_next_Click;
            // 
            // Form_single_question
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 338);
            Controls.Add(button_next);
            Controls.Add(button_previous);
            Controls.Add(radioButton_answer8);
            Controls.Add(radioButton_answer7);
            Controls.Add(radioButton_answer6);
            Controls.Add(radioButton_answer5);
            Controls.Add(radioButton_answer4);
            Controls.Add(radioButton_answer3);
            Controls.Add(radioButton_answer2);
            Controls.Add(radioButton_answer1);
            Controls.Add(label_question);
            Name = "Form_single_question";
            Text = "Form_single_question";
            FormClosing += Form_single_question_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_previous;
        private Button button_next;
        internal Label label_question;
        internal RadioButton radioButton_answer1;
        internal RadioButton radioButton_answer2;
        internal RadioButton radioButton_answer3;
        internal RadioButton radioButton_answer4;
        internal RadioButton radioButton_answer5;
        internal RadioButton radioButton_answer6;
        internal RadioButton radioButton_answer7;
        internal RadioButton radioButton_answer8;
    }
}