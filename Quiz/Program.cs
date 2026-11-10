using System.Diagnostics;

namespace Quiz
{
    internal static class Program
    {
        public static List<QuestionClass> QuestionsList = new List<QuestionClass>();
        public static List<Form> QuestionForms = new List<Form>();
        public static Stopwatch QuizTimer = new Stopwatch();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            InitializeQuestions();
            InitializeForms();
            Application.Run(new Form_start());
        }

        static void InitializeQuestions()
        {

            QuestionsList.Add(new SingleQuestionClass(
                1,
                "Jak nazywał się oficjalny ustrój polityczny Rumunii w okresie komunistycznym (od 1947 roku)?",
                [
                    "a) Socjalistyczna Republika Rumunii",
                    "b) Demokratyczna Republika Rumunii",
                    "c) Ludowa Republika Rumunii",
                    "d) Komunistyczna Republika Rumunii"
                ],
                0
            ));
            QuestionsList.Add(new SingleQuestionClass(
                2,
                "Jak nazywała się poteżna i przerażająca rumuńska tajna policja polityczna, która inwigilowała\nspołeczeństwo w czasach komunizmu?",
                [
                    "a) Stasi",
                    "b) KGB",
                    "c) UB",
                    "d) SB",
                    "e) Securitate",
                    "f) AVO"
                ],
                4
            ));
            QuestionsList.Add(new SingleQuestionClass(
                3,
                "Które miasto było głównym punktem zapalnym rumuńskiej rewolucji w grudniu 1989 roku,\ngdzie doszło do masowych protestów stłumionych przez Securitate?",
                [
                    "a) Bukareszt",
                    "b) Timișoara (Temeszwar)",
                    "c) Kluż-Napoka",
                    "d) Konstanca"
                ],
                1
            ));
            QuestionsList.Add(new MultipleQuestionClass(
                4,
                "Które z poniższych stwierdzeń dotyczą okresu dyktatorskich rządów Nicolae Ceaușescu?",
                [
                    "a) Wokół dyktatora i jego żony Eleny stworzono potężny kult jednostki",
                    "b) Kraj zmagał się z gigantycznym zadłużeniem zagranicznym, spłacanym kosztem ogromnych wyrzeczeń społeczeństwa",
                    "c) Rumunia nie utrzymywała żadnych kontaktów dyplomatycznych ani handlowych z Zachodem",
                    "d) Państwo prowadziło niezwykle restrykcyjną politykę demograficzną, co doprowadziło do kryzysu społecznego",
                ],
                [0,1,3]
            ));
            QuestionsList.Add(new MultipleQuestionClass(
                5,
                "W czym wyrażała się specyfika polityki zagranicznej i niezależność Rumunii pod rządami\nNicolae Ceaușescu w latach 60. i 70. XX wieku?",
                [
                    "a) Potępieniem inwazji wojsk Układu Warszawskiego na Czechosłowację w 1968 roku",
                    "b) Całkowitym wystąpieniem Rumunii z Paktu Północnoatlantyckiego (NATO)",
                    "c) Prowadzeniem elastycznej polityki migracyjnej wobec obywateli Rumunii",
                    "d) Utrzymywaniem dobrych relacji dyplomatycznych i gospodarczych z Izraelem oraz Chinami",
                    "e) Prowadzeniem względnie niezależnej polityki wobec Moskwy, za co Ceaușescu zyskał czasowe poparcie państw zachodnich",
                ],
                [0, 3, 4]
            ));
            QuestionsList.Add(new MultipleQuestionClass(
                6,
                "Jaki rezultat przyniosła rewolucja pod koniec grudnia 1989 roku w Rumunii?",
                [
                    "a) Doprowadzono do demokratycznych wyborów, w wyniku których Ceaușescu został zmuszony dobrowolnie zrzec się władzy",
                    "b) Nicolae Ceaușescu nie chciał dobrowolnie oddać władzy rozkazując wojsku użyć ostrej amunicji wobec protestujących",
                    "c) W rezultacie nieudanej rewolucji Nicolae Ceaușescu utrzymał się u władzy i rządził przez następne lata",
                    "d) W konluzji udanej rewolucji Nicolae i Elena Ceaușescu zostali aresztowani i sakzani na karę śmierci",
                    "e) Po rewolucji władzę w kraju bezkrwawo przejęła stara gwardia komunistyczna",
                    "f) Powszechne protesty i przejście armii na stronę narodu dorpowadziły do ostatecznego upadku komunistycznego reżimu"
                ],
                [1, 3, 5]
            ));
            QuestionsList.Add(new MultipleQuestionClass(
                7,
                "Które z poniższych stwierdzeń dotyczą tzw. „Eksperymentu Pitești” z lat 50. XX wieku?",
                [
                    "a) Brutalna 're-edukacja' i katowanie więźniów przez innych więźniów",
                    "b) Oficjalny program wymiany więźniów z Zachodem",
                    "c) Nadzorowany m.in. przez Eugena Țurcanu, uznany za okrutne zjawisko systemowe",
                    "d) Dotyczył wyłącznie pracy w kopalniach uranu",
                    "e) Przerwany procesem i wyrokami śmierci dla organizatorów w 1954 r"
                ],
                [0, 2, 4]
            ));
            QuestionsList.Add(new SingleQuestionClass(
                8,
                "Jak mianowano i w jakim celu wykorzystywaną siłę roboczą przy budowie Kanału\nDunaj-Czarne Morze?",
                [
                    "a) Robotnicy kontraktowi z Korei Północnej",
                    "b) Więźniowie polityczni i 'wrogowie klasowi' w obozach pracy zwanych cmentarzem burżuazji",
                    "c) Wolontariusze z młodzieżowych brygad w czynie społecznym",
                    "d) Żołnierze Armii Radzieckiej"
                ],
                1
            ));
        }

        static void InitializeForms()
        {
            foreach (QuestionClass questionClass in QuestionsList)
            {
                if (questionClass is SingleQuestionClass singleQuestionClass)
                {
                    Form_single_question form = new Form_single_question();
                    form.LoadQuestion(singleQuestionClass);
                    form.Hide();
                    QuestionForms.Add(form);
                }
                else if (questionClass is MultipleQuestionClass multipleQuestionClass)
                {
                    Form_multiple_questions form = new Form_multiple_questions();
                    form.LoadQuestion(multipleQuestionClass);
                    form.Hide();
                    QuestionForms.Add(form);
                }
            }
        }
    }
}