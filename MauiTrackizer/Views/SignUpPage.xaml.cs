namespace MauiTrackizer.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private async void SignInButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}