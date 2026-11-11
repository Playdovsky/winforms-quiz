namespace Quiz
{
    partial class Form_start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_subtitle = new Label();
            label_title = new Label();
            button_start = new Button();
            label_info = new Label();
            SuspendLayout();
            // 
            // label_subtitle
            // 
            label_subtitle.AutoSize = true;
            label_subtitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label_subtitle.Location = new Point(54, 52);
            label_subtitle.Name = "label_subtitle";
            label_subtitle.Size = new Size(230, 21);
            label_subtitle.TabIndex = 0;
            label_subtitle.Text = "Rumunia po II wojnie światowej";
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label_title.Location = new Point(130, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(66, 32);
            label_title.TabIndex = 1;
            label_title.Text = "Quiz";
            // 
            // button_start
            // 
            button_start.Location = new Point(95, 168);
            button_start.Name = "button_start";
            button_start.Size = new Size(128, 23);
            button_start.TabIndex = 2;
            button_start.Text = "Rozpocznij!";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // label_info
            // 
            label_info.AutoSize = true;
            label_info.Location = new Point(54, 90);
            label_info.Name = "label_info";
            label_info.Size = new Size(218, 75);
            label_info.TabIndex = 3;
            label_info.Text = "Quiz składa się z X pytań.\r\nPytania nie są ograniczone czasowo.\r\nMiędzy pytaniami można swobodnie się\r\nporuszać i zmieniać odpowiedzi.\r\n\r\n";
            label_info.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 220);
            Controls.Add(label_info);
            Controls.Add(button_start);
            Controls.Add(label_title);
            Controls.Add(label_subtitle);
            Name = "Form_start";
            Text = "Powojenna Rumunia Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_subtitle;
        private Label label_title;
        private Button button_start;
        private Label label_info;
    }
}
