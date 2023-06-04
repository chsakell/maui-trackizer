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
}