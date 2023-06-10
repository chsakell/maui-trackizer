namespace MauiTrackizer.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    private async void GetStartedButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpOptionsPage());
    }

    private async void AccountButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}