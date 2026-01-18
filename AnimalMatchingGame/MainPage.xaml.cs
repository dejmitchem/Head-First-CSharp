namespace AnimalMatchingGame
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            AnimalButtons.IsVisible = true;
            PlayAgainButton.IsVisible = false;

            List<string> animalEmoji = [
                "🐕","🐕",
                "🐈","🐈",
                "🐅","🐅",
                "🐟","🐟",
                "🦒","🦒",
                "🦛","🦛",
                "🐊","🐊",
                "🐘","🐘"
                ];

            foreach (var button in AnimalButtons.Children.OfType<Button>())
            { 
                int index = Random.Shared.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                button.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }

        Button lastClicked;
        bool findingMatch = false;
        int matchesFound = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button buttonClicked)
            {
                if (!string.IsNullOrWhiteSpace(buttonClicked.Text) && (findingMatch == false))
                {

                    buttonClicked.BackgroundColor = Colors.Red;
                    lastClicked = buttonClicked;
                    findingMatch = true;
                }
                else
                {
                    if ((buttonClicked != lastClicked) && (buttonClicked.Text == lastClicked.Text) && (buttonClicked.Text != " "))
                    {
                        matchesFound++;
                        lastClicked.Text = " ";
                        buttonClicked.Text = " ";
                    }
                    lastClicked.BackgroundColor = Colors.LightBlue;
                    buttonClicked.BackgroundColor = Colors.LightBlue;
                    findingMatch = false;
                }
            }
            if (matchesFound == 8)
            {
                AnimalButtons.IsVisible = false;
                PlayAgainButton.IsVisible = true;
                matchesFound = 0;
            }
            }
        }
    }
