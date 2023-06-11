#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

using MauiTrackizer.Core;
using MauiTrackizer.Handlers;
using MauiTrackizer.Views;

namespace MauiTrackizer;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        #region Handlers

        //Borderless entry
        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderlessEntry), (handler, view) =>
        {
            if (view is BorderlessEntry)
            {
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif __WINDOWS__
                handler.PlatformView.FontWeight = Microsoft.UI.Text.FontWeights.Thin;
                handler.PlatformView.TextBox.BorderThickness = new Thickness(0);
#endif
            }
        });

        #endregion

#if WINDOWS
        SetWindowsSize();
#endif
        if (AppSettings.IsFirstLaunching)
        {
            AppSettings.IsFirstLaunching = true; //Set to 'false' in production
            MainPage = new NavigationPage(new WelcomePage())
            {
                BackgroundColor = Color.FromRgb(28, 28, 35),
                BarBackgroundColor = Color.FromRgb(28, 28, 35),
                BarTextColor = Color.FromRgb(162, 162, 181)
            };
        }
        else
        {
            MainPage = new AppShell();
        }
	}

	private void SetWindowsSize()
	{
        //Set App size on MS Windows
        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
#if WINDOWS
            const int WindowWidth = 540;
            const int WindowHeight = 1000;

            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
#endif
        });
    }
}
