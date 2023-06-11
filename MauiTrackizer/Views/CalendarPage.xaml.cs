using MauiTrackizer.Models;
using MauiTrackizer.ViewModels;

namespace MauiTrackizer.Views;

public partial class CalendarPage : ContentPage
{
    public CalendarPage()
    {
        InitializeComponent();

        var calendar = new CalendarViewModel();
        calendar.Days.Add(new DayModel()
        {
            Date = "08",
            Day = "Mo",
            IsSelected = true
        });
        calendar.Days.Add(new DayModel()
        {
            Date = "09",
            Day = "Tu"
        });
        calendar.Days.Add(new DayModel()
        {
            Date = "10",
            Day = "We"
        });
        calendar.Days.Add(new DayModel()
        {
            Date = "11",
            Day = "Th"
        });
        calendar.Days.Add(new DayModel()
        {
            Date = "12",
            Day = "Fr"
        });
        calendar.Days.Add(new DayModel()
        {
            Date = "13",
            Day = "Sa"
        });
        calendar.Days.Add(new DayModel()
        {
            Date = "14",
            Day = "Su"
        });

        calendar.Subscriptions.Add(new Subscription()
        {
            Icon = "spotify_logo.png",
            Name = "Spotify",
            Cost = "$5.99"
        });
        calendar.Subscriptions.Add(new Subscription()
        {
            Icon = "youtube_logo.png",
            Name = "YouTube Premium",
            Cost = "$18.99"
        });
        calendar.Subscriptions.Add(new Subscription()
        {
            Icon = "onedrive_logo.png",
            Name = "OneDrive",
            Cost = "$15.99"
        });

        BindingContext = calendar;

    }
}