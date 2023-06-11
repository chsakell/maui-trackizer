using MauiTrackizer.Models;
using MauiTrackizer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTrackizer.Selectors
{
    public class CalendarDaySelector : DataTemplateSelector
    {
        public DataTemplate SelectedTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((DayModel)item).IsSelected ? SelectedTemplate : DefaultTemplate;
        }
    }
}
