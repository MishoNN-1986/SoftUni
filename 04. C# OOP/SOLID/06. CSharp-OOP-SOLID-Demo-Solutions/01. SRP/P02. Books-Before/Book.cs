namespace P02._Books_Before
{
    public class Book //книгата не трябва да си знае локацията
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public int Location { get; set; }

        public string TurnPage(int page)
        {
            return "Current page";
        }
    }
}
