using MauiTrackizer.Controls;

namespace MauiTrackizer.Views;

public partial class SubscriptionInfoPage : BasePopupPage
{
	public SubscriptionInfoPage(SubscriptionInfo subscriptionInfo)
	{
		InitializeComponent();

		BindingContext = new SubscriptionInfoViewModel() { SubscriptionInfo = subscriptionInfo };
	}
}

public class SubscriptionInfoViewModel
{
	public SubscriptionInfo SubscriptionInfo { get; set; }
}