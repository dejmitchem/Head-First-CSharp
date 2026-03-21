using MauiCards;

namespace TwoDecks
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }



        private Deck GetDeckFromResources(string key) 
        { 
            if (Resources.TryGetValue(key, out object resource) && resource is Deck deck)
                return deck;
            else
                return new Deck();
        }

        private void MoveCard1_Clicked(object sender, EventArgs e)
        {
            if (Deck1.SelectedItem is Card card)
            {
                GetDeckFromResources("Deck2").Add(card);
                GetDeckFromResources("Deck1").Remove(card);
            }
        }

        private void Shuffle1_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck1").Shuffle();
        }

        private void Sort1_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck1").Sort();
        }

        private void Reset1_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck1").Reset();
        }

        private void Clear1_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck1").Clear();
        }

        private void MoveCard2_Clicked(object sender, EventArgs e)
        {
            if (Deck2.SelectedItem is Card card)
            {
                GetDeckFromResources("Deck1").Add(card);
                GetDeckFromResources("Deck2").Remove(card);
            }
        }

        private void Shuffle2_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck2").Shuffle();
        }

        private void Sort2_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck2").Sort();
        }

        private void Reset2_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck2").Reset();
        }

        private void Clear2_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck2").Clear();
        }
    }
}
