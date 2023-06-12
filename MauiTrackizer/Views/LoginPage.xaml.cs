namespace MauiTrackizer.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(HomePage));
    }
}