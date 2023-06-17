using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using LiveChartsCore;
using MauiTrackizer.Controls;
using MauiTrackizer.Core;
using MauiTrackizer.Models;

namespace MauiTrackizer.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();

        BindingContext = new HomeViewModel();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await PopupAction.DisplayPopup(new AddSubscriptionPage());
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var subscriptions = new List<SubscriptionInfo>()
        {
            new SubscriptionInfo()
            {
                Name = "Spotify",
                Icon = "spotify_logo.png",
                Cost = "$5.99",
                Description = "Music app",
                Category = "Entertainment",
                FirstPayment = "08.01.2023",
                Reminder = "Never",
                Currency = "USD ($)"
            },
            new SubscriptionInfo()
            {
                Name = "OneDrive",
                Icon = "onedrive_logo.png",
                Cost = "$15.99",
                Description = "Cloude storage",
                Category = "Storage",
                FirstPayment = "08.01.2023",
                Reminder = "Never",
                Currency = "USD ($)"
            },
            new SubscriptionInfo()
            {
                Name = "YouTube",
                Icon = "youtube_logo.png",
                Cost = "$6.99",
                Description = "Music app",
                Category = "Entertainment",
                FirstPayment = "07.05.2023",
                Reminder = "Monthly",
                Currency = "USD ($)"
            }
        };

        var subscription = subscriptions
            .FirstOrDefault(sub => sub.Name.Equals(e.Parameter.ToString(),
            StringComparison.InvariantCultureIgnoreCase));

        await PopupAction.DisplayPopup(new SubscriptionInfoPage(subscription));
    }

    private async void SettingsButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("settings");
    }
}