using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MauiTrackizer;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        //Window.SetStatusBarColor(new Android.Graphics.Color(28,28,35));

        base.OnCreate(savedInstanceState);
    }
}
