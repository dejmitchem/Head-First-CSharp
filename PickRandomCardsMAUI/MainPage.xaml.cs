using PickRandomCards;

namespace PickRandomCardsMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PickCardsButton_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(NumberOfCards.Text, out int numberOfCardsInt))
            {
                string[] cards = CardPicker.PickSomeCards(numberOfCardsInt);
                foreach (string card in cards)
                {
                    PickedCards.Text += card + Environment.NewLine;
                }
            }
        
            else { 
                PickedCards.Text = "Please enter a valid number.";
            }
            
            

        }
    }
}
