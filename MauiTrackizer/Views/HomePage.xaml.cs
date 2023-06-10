using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using LiveChartsCore;
using MauiTrackizer.Controls;

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

public class HomeViewModel
{
    public IEnumerable<ISeries> DegreesGaugePieSeries { get; set; }
    public HomeViewModel()
    {

        DegreesGaugePieSeries = new GaugeBuilder()
        //.WithLabelsSize(50)
        .WithInnerRadius(280)
        .WithBackgroundInnerRadius(280)
        .WithBackground(null)
        .WithLabelsSize(0)
        .WithLabelsPosition(PolarLabelsPosition.ChartCenter)
        .AddValue(85, "gauge value", new SKColor(255, 121, 102), SKColors.White)
        .BuildSeries();
    }
}

public class SubscriptionInfo
{
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public string Cost { get; set; }
    public string Category { get; set; }
    public string FirstPayment { get; set; }
    public string Reminder { get; set; }
    public string Currency { get; set; }
}