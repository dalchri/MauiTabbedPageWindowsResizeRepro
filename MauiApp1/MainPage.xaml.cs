namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPageButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void TabbedPageButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TabbedPage();
        }
    }

}
