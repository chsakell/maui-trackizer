using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using SkiaSharp;
using MauiTrackizer.Models;
using MauiTrackizer.Constants;
using MauiTrackizer.ViewModels;

namespace MauiTrackizer.Views;

public partial class SpendingBudgetsPage : ContentPage
{
    public SpendingBudgetsPage()
    {
        InitializeComponent();

        BindingContext = new SpendingBudgetsPageViewModel();
    }
}
