using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using LiveChartsCore;

namespace MauiTrackizer.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

		BindingContext = new HomeViewModel();
	}
}

public class HomeViewModel
{
    public IEnumerable<ISeries> DegreesGaugePieSeries { get; set; }
    public HomeViewModel() {

        DegreesGaugePieSeries = new GaugeBuilder()
        //.WithLabelsSize(50)
        .WithInnerRadius(250)
        .WithBackgroundInnerRadius(250)
        .WithBackground(null)
        .WithLabelsSize(0)
        .WithLabelsPosition(PolarLabelsPosition.ChartCenter)
        .AddValue(85, "gauge value", new SKColor(255,121,102), SKColors.White)
        .BuildSeries();
    }
}