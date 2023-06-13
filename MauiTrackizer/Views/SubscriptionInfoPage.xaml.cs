using MauiTrackizer.Controls;
using MauiTrackizer.Models;
using MauiTrackizer.ViewModels;

namespace MauiTrackizer.Views;

public partial class SubscriptionInfoPage : BasePopupPage
{
	public SubscriptionInfoPage(SubscriptionInfo subscriptionInfo)
	{
		InitializeComponent();

		BindingContext = new SubscriptionInfoViewModel() { SubscriptionInfo = subscriptionInfo };
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await PopupAction.ClosePopup();
    }
}