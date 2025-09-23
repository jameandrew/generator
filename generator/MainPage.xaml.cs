namespace generator;

public partial class MainPage : ContentPage
{
    private readonly List<(string Text, string Author)> _quotes;
    private readonly Random _random;

    public MainPage()
    {
        InitializeComponent();

        _random = new Random();

        _quotes = new List<(string, string)>
        {
            ("The only limit to our realization of tomorrow is our doubts of today.", "Franklin D. Roosevelt"),
            ("Do what you can, with what you have, where you are.", "Theodore Roosevelt"),
            ("It does not matter how slowly you go as long as you do not stop.", "Confucius"),
            ("In the middle of every difficulty lies opportunity.", "Albert Einstein"),
            ("Happiness depends upon ourselves.", "Aristotle"),
            ("If you're hungry eat", "Monkey D. Luffy"),
            ("When do you think people die? When they are shot with a bullet? No! When they eat a soup made from a poisonous mushroom? No! People die... when they are forgotten.", "Dr. Hiluluk"),
            ("Power comes in response to a need, not a desire. You have to create that need.", "Frank Herbert, Dune"),
            ("A lesson without pain is meaningless. That's because you can't gain something without sacrificing something in return. But once you sacrifice, you never truly lose it.", "Edward Elric"),
            ("Fear is not evil. It tells you what your weakness is. And once you know your weakness, you can become stronger as well as kinder.", "Gildarts Clive"),
            ("The world isn't perfect. But it's there for us, doing the best it can... that's what makes it so damn beautiful.", "Roy Mustang"),
            ("With great power comes with great responsibility", "Uncle Ben"),
        };

        NewQuoteBtn.Clicked += (s, e) => ShowRandom();
        ShowRandom();
    }

    private void ShowRandom()
    {
        if (_quotes.Count == 0)
        {
            QuoteLabel.Text = "No quotes available.";
            AuthorLabel.Text = "";
            return;
        }

        var q = _quotes[_random.Next(_quotes.Count)];
        QuoteLabel.Text = $"\"{q.Text}\"";
        AuthorLabel.Text = $"— {q.Author}";
    }
}
