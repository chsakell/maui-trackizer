using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using LiveChartsCore;
using MauiTrackizer.Controls;

namespace MauiTrackizer.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();

		BindingContext = new HomeViewModel();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await PopupAction.DisplayPopup(new AddSubscriptionPage());
    }
}

public class HomeViewModel
{
    public IEnumerable<ISeries> DegreesGaugePieSeries { get; set; }
    public HomeViewModel() {

        DegreesGaugePieSeries = new GaugeBuilder()
        //.WithLabelsSize(50)
        .WithInnerRadius(280)
        .WithBackgroundInnerRadius(280)
        .WithBackground(null)
        .WithLabelsSize(0)
        .WithLabelsPosition(PolarLabelsPosition.ChartCenter)
        .AddValue(85, "gauge value", new SKColor(255,121,102), SKColors.White)
        .BuildSeries();
    }
}