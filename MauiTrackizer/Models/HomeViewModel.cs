using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTrackizer.Models
{
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
}
