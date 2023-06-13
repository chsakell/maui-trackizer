using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTrackizer.Models
{
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
}
