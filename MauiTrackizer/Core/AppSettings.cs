using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTrackizer.Core
{
    public class AppSettings
    {
        public static AppSettings Instance { get; }

        static AppSettings()
        {
            Instance = new AppSettings();
        }

        private AppSettings()
        {
        }

        public static bool IsFirstLaunching
        {
            get => Preferences.Get(nameof(IsFirstLaunching), true);
            set => Preferences.Set(nameof(IsFirstLaunching), value);
        }
    }
}
