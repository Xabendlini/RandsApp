
namespace RandsApp2;

public partial class VerificationPage : ContentPage
{
    public VerificationPage()
    {
        InitializeComponent();

    }
    private async  void OnVerifyClicked(object sender, EventArgs e)
    { 



        DateTime currentDate = DateTime.Now;
        DateTime birthdate = birthdatePicker.Date;

        int age = currentDate.Year - birthdate.Year;

        if (currentDate.Month < birthdate.Month || (currentDate.Month == birthdate.Month && currentDate.Day < birthdate.Day)) 
        {


        }

        if(age >= 21)
        {

          await Navigation.PushAsync(new MenuPage());

            //
        }
        else
        {

            await DisplayAlert("Age Verification", "You must be 21 or older to proceed", "Ok");

        }
    }
}