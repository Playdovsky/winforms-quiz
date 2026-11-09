namespace Quiz
{
    public partial class Form_start : Form
    {
        public Form_start()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Program.QuestionForms[0].Show();
            this.Hide();
        }
    }
}
