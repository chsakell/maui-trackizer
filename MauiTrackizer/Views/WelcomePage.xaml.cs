namespace MauiTrackizer.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    private async void GetStartedButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignUpOptionsPage));
    }

    private async void AccountButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}