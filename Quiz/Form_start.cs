namespace Quiz
{
    public partial class Form_start : Form
    {
        public Form_start()
        {
            InitializeComponent();
            this.Icon = new Icon("Flag_of_Romania.ico");
            label_info.Text = 
                $"Test składa się z {Program.QuestionsList.Count().ToString()} pytań.\n" +
                "Pytania nie są ograniczone czasowo.\n" +
                "Między pytaniami można swobodnie się\n" +
                "poruszać i zmieniać odpowiedzi.\n";
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Program.QuestionForms[0].Show();
            this.Hide();
        }
    }
}
