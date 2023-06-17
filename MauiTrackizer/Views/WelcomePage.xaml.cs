using MauiTrackizer.Core;

namespace MauiTrackizer.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		InitializeComponent();
	}

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        if (AppSettings.IsFirstLaunching)
        {
            AppSettings.IsFirstLaunching = false;
            base.OnNavigatedTo(args);
        }
        else
        {
            var tab = Shell.Current.FindByName("WelcomeTab") as Tab;
            tab.IsVisible = false;
            await Shell.Current.GoToAsync(nameof(HomePage));
        }
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