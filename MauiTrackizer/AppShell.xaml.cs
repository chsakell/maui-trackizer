using MauiTrackizer.Views;

namespace MauiTrackizer;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("settings", typeof(SettingsPage));
    }
}
