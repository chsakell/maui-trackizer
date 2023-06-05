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
            Day = "Mo"
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

        BindingContext = calendar;

    }
}

public class CalendarViewModel
{
    public List<DayModel> Days { get; set; }
}

public class DayModel
{
    public string Date { get; set; }
    public string Day { get; set; }
}