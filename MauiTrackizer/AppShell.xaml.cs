using MauiTrackizer.Core;
using MauiTrackizer.Views;

namespace MauiTrackizer;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("settings", typeof(SettingsPage));
		Routing.RegisterRoute(nameof(WelcomePage), typeof(WelcomePage));
        Routing.RegisterRoute(nameof(SignUpOptionsPage), typeof(SignUpOptionsPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
    }
}
