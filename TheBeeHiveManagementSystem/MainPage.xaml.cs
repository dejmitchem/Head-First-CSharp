namespace TheBeeHiveManagementSystem
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            JobPicker.ItemsSource = new string[]
            {
                "Nectar Collector",
                "Honey Manufacturer",
                "Egg Care",
            };

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void WorkShiftButton_Clicked(object sender, EventArgs e)
        {

        }

        private void OutOfHoneyButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}
