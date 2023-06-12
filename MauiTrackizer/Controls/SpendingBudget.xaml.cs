using MauiTrackizer.Models;

namespace MauiTrackizer.Controls;

public partial class SpendingBudgetControl : ContentView
{
    #region Bindable Properties

    public static BindableProperty SpendingBudgetProperty = BindableProperty
        .Create(nameof(SpendingBudget), typeof(SpendingBudget), typeof(SpendingBudgetControl), new SpendingBudget(),
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: (bindable, oldValue, newValue) =>
        {

            Console.WriteLine($"{oldValue} ({newValue})");
        });

    public static BindableProperty IconProperty = BindableProperty
        .Create(nameof(Icon), typeof(string), typeof(SpendingBudgetControl), string.Empty,
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: (bindable, oldValue, newValue) =>
        {

            Console.WriteLine($"{oldValue} ({newValue})");
        });

    public static BindableProperty TitleProperty = BindableProperty
        .Create(nameof(Title), typeof(string), typeof(SpendingBudgetControl), string.Empty,
        propertyChanged: (bindable, oldValue, newValue) =>
        {

            Console.WriteLine($"{oldValue} ({newValue})");
        });

    public static BindableProperty SubtitleProperty = BindableProperty
        .Create(nameof(Subtitle), typeof(string), typeof(SpendingBudgetControl), string.Empty,
        propertyChanged: (bindable, oldValue, newValue) =>
        {

            Console.WriteLine($"{oldValue} ({newValue})");
        });

    public static BindableProperty CostProperty = BindableProperty
        .Create(nameof(Cost), typeof(string), typeof(SpendingBudgetControl), string.Empty,
        propertyChanged: (bindable, oldValue, newValue) =>
        {

            Console.WriteLine($"{oldValue} ({newValue})");
        });

    public static BindableProperty TotalCostProperty = BindableProperty
        .Create(nameof(TotalCost), typeof(string), typeof(SpendingBudgetControl), string.Empty,
        propertyChanged: (bindable, oldValue, newValue) =>
        {

            Console.WriteLine($"{oldValue} ({newValue})");
        });

    #endregion

    public SpendingBudgetControl()
    {
        InitializeComponent();
    }

    #region Properties


    public SpendingBudget SpendingBudget
    {
        get => (SpendingBudget)GetValue(SpendingBudgetProperty);
        set => SetValue(SpendingBudgetProperty, value);
    }

    public string Icon
    {
        get => (string)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public string Subtitle
    {
        get => (string)GetValue(SubtitleProperty);
        set => SetValue(SubtitleProperty, value);
    }

    public string Cost
    {
        get => (string)GetValue(CostProperty);
        set => SetValue(CostProperty, value);
    }

    public string TotalCost
    {
        get => (string)GetValue(TotalCostProperty);
        set => SetValue(TotalCostProperty, value);
    }

    #endregion
}