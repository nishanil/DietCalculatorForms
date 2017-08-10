namespace DietCalculator.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new DietCalculator.App());
        }
    }
}