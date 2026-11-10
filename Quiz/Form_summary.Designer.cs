namespace Quiz
{
    partial class Form_summary
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
            label_title = new Label();
            label_subtitle = new Label();
            flowLayoutPanel_answers_summary = new FlowLayoutPanel();
            label_timer = new Label();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_title.Location = new Point(206, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(188, 32);
            label_title.TabIndex = 0;
            label_title.Text = "Podsumowanie";
            // 
            // label_subtitle
            // 
            label_subtitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_subtitle.AutoSize = true;
            label_subtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_subtitle.Location = new Point(249, 41);
            label_subtitle.Name = "label_subtitle";
            label_subtitle.Size = new Size(93, 21);
            label_subtitle.TabIndex = 1;
            label_subtitle.Text = "Wynik: 0/0";
            // 
            // flowLayoutPanel_answers_summary
            // 
            flowLayoutPanel_answers_summary.AutoScroll = true;
            flowLayoutPanel_answers_summary.Location = new Point(12, 126);
            flowLayoutPanel_answers_summary.Name = "flowLayoutPanel_answers_summary";
            flowLayoutPanel_answers_summary.Size = new Size(575, 373);
            flowLayoutPanel_answers_summary.TabIndex = 2;
            // 
            // label_timer
            // 
            label_timer.AutoSize = true;
            label_timer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_timer.Location = new Point(206, 85);
            label_timer.Name = "label_timer";
            label_timer.Size = new Size(182, 15);
            label_timer.TabIndex = 3;
            label_timer.Text = "Quiz zakończony w 5 min i 15 sek";
            // 
            // Form_summary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 511);
            Controls.Add(label_timer);
            Controls.Add(flowLayoutPanel_answers_summary);
            Controls.Add(label_subtitle);
            Controls.Add(label_title);
            Name = "Form_summary";
            Text = "Powojenna Rumunia Quiz - Podsumowanie";
            FormClosing += Form_summary_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        private Label label_subtitle;
        private FlowLayoutPanel flowLayoutPanel_answers_summary;
        private Label label_timer;
    }
}