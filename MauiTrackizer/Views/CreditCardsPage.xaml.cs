namespace MauiTrackizer.Views;

public partial class CreditCardsPage : ContentPage
{
	public CreditCardsPage()
	{
		InitializeComponent();

		var vm = new CreditCardsViewModel();
		vm.Cards.Add(new Card()
		{
			Icon = "card_1.png"
		});
        vm.Cards.Add(new Card()
        {
            Icon = "card_2.png"
        });
        vm.Cards.Add(new Card()
        {
            Icon = "card_3.png"
        });

        BindingContext = vm;
    }
}

public class CreditCardsViewModel
{
	public List<Card> Cards { get; set; }

    public CreditCardsViewModel()
    {
        Cards = new List<Card>();
    }
}

public class Card
{
	public string Icon { get; set; }
}