using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;

namespace MauiTrackizer.Views;

public partial class SpendingBudgetsPage : ContentPage
{
	public SpendingBudgetsPage()
	{
		InitializeComponent();

		BindingContext = new SpendingBudgetsPageViewModel();
	}
}

public class SpendingBudgetsPageViewModel
{
	public string Title { get; set; } = "Spending & Budgets";
    public IEnumerable<ISeries> DegreesGaugePieSeries { get; set; }
    public SpendingBudgetsPageViewModel()
    {

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