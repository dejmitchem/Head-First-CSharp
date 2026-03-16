using System.Collections.ObjectModel;
using CardClass;

namespace MauiCards
{
    public partial class MainPage : ContentPage
    {

        private Deck myItems = new Deck();

        public MainPage()
        {
            InitializeComponent();
            MyItems.ItemsSource = myItems;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            myItems.Add(
                new Card((Suits)Random.Shared.Next(4), (Values)Random.Shared.Next(1, 14)));
        }

        private void MyItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyItems.SelectedItem == null) SelectedCard.Text = "No card selected";
            else SelectedCard.Text = $"You selected {MyItems.SelectedItem}";
    
        }

        private void Shuffle_Clicked(object sender, EventArgs e)
        {
            myItems.Shuffle();
        }

        private void Sort_Clicked(object sender, EventArgs e)
        {
            myItems.Sort();
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            myItems.Reset();
        }

        private void Clear_Clicked(object sender, EventArgs e)
        {
            myItems.Clear();
        }
    }
}
