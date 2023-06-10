namespace MauiTrackizer.Views;

public partial class SignUpOptionsPage : ContentPage
{
	public SignUpOptionsPage()
	{
		InitializeComponent();
	}

    private async void SignUpWithEmail_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpPage());
    }
}