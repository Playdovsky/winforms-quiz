namespace Quiz
{
    internal static class Program
    {
        public static List<QuestionClass> SingleQuestionsList = new List<QuestionClass>();
        public static List<Form> QuestionForms = new List<Form>();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            InitializeQuestions();
            Application.Run(new Form_start());
        }

        static void InitializeQuestions()
        {

            SingleQuestionsList.Add(new SingleQuestionClass(
                1,
                "Jak nazywał się oficjalny ustrój polityczny Rumunii w okresie komunistycznym (od 1947 roku)?",
                ["a) Socjalistyczna Republika Rumunii", "b) Demokratyczna Republika Rumunii", "c) Ludowa Republika Rumunii", "d) Komunistyczna Republika Rumunii"],
                0
            ));
            SingleQuestionsList.Add(new SingleQuestionClass(
                2,
                "Jak nazywała się poteżna i przerażająca rumuńska tajna policja polityczna, która inwigilowała społeczeństwo w czasach komunizmu?",
                ["a) Stasi", "b) KGB", "c) UB", "d) SB", "e) Securitate", "f) AVO"],
                4
            ));
            SingleQuestionsList.Add(new SingleQuestionClass(
                3,
                "Które miasto było głównym punktem zapalnym rumuńskiej rewolucji w grudniu 1989 roku, gdzie doszło do masowych protestów stłumionych przez Securitate?",
                ["a) Bukareszt", "b) Timișoara (Temeszwar)", "c) Kluż-Napoka", "d) Konstanca"],
                1
            ));

            foreach (SingleQuestionClass questionClass in SingleQuestionsList)
            {
                Form_single_question form = new Form_single_question();
                form.LoadQuestion(questionClass);
                form.Hide();
                QuestionForms.Add(form);
            }
        }
    }
}