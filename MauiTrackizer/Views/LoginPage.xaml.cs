namespace MauiTrackizer.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var tab = Shell.Current.FindByName("WelcomeTab") as Tab;
        tab.IsVisible = false;
        await Shell.Current.GoToAsync(nameof(HomePage));
    }
}