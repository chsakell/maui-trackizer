using MauiTrackizer.Models;

namespace MauiTrackizer.ViewModels
{
    public class CalendarViewModel
    {
        public List<DayModel> Days { get; set; }
        public List<Subscription> Subscriptions { get; set; }

        public CalendarViewModel()
        {
            Days = new List<DayModel>();
            Subscriptions = new List<Subscription>();
        }
    }
}
