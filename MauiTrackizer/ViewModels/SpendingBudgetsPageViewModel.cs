using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using MauiTrackizer.Constants;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiTrackizer.Models;

namespace MauiTrackizer.ViewModels
{
    public class SpendingBudgetsPageViewModel
    {
        public string Title { get; set; } = "Spending & Budgets";

        public SpendingBudget AutoTransport { get; set; }
        public SpendingBudget Entertainment { get; set; }
        public SpendingBudget Security { get; set; }
        public IEnumerable<ISeries> DegreesGaugePieSeries { get; set; }
        public SpendingBudgetsPageViewModel()
        {
            AutoTransport = new SpendingBudget()
            {
                Title = "Auto & transport",
                Subtitle = "$375 left to spend",
                Icon = MaterialIcons.Car_repair,
                Cost = "$254.99",
                TotalCost = "of 400",
                Progress = 0.2,
                ProgressColor = Color.FromRgb(0, 250, 217)
            };

            Entertainment = new SpendingBudget()
            {
                Title = "Entertainment",
                Subtitle = "$375 left to spend",
                Icon = MaterialIcons.Nightlife,
                Cost = "$50.99",
                TotalCost = "of 600",
                Progress = 0.5,
                ProgressColor = Color.FromRgb(255, 166, 153)
            };

            Security = new SpendingBudget()
            {
                Title = "Security",
                Subtitle = "$375 left to spend",
                Icon = MaterialIcons.Fingerprint,
                Cost = "$5.99",
                TotalCost = "of 600",
                Progress = 0.8,
                ProgressColor = Color.FromRgb(94, 0, 245)
            };

            DegreesGaugePieSeries = new GaugeBuilder()
            //.WithLabelsSize(50)
            .WithInnerRadius(230)
            .WithBackgroundInnerRadius(230)
            .WithLabelsSize(0)
            .WithLabelsPosition(PolarLabelsPosition.ChartCenter)
            .AddValue(20, "gauge value", new SKColor(0, 250, 217), SKColors.White)
            .AddValue(50, "gauge value", new SKColor(255, 121, 102), SKColors.White)
            .AddValue(85, "gauge value", new SKColor(94, 0, 245), SKColors.White)
            .BuildSeries();
        }
    }
}
