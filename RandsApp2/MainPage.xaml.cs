namespace RandsApp2
{
    public partial class MainPage : ContentPage
    { 

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {

            //add your login logic here


            Navigation.PushAsync(new VerificationPage());
        }

        private void OnVerifyClicked(object sender, EventArgs e)
        {


            Navigation.PushAsync(new MenuPage ());
        }

    }

}
