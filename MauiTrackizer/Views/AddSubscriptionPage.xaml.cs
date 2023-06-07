using MauiTrackizer.Controls;

namespace MauiTrackizer.Views;

public partial class AddSubscriptionPage : BasePopupPage
{
	public AddSubscriptionPage()
	{
		InitializeComponent();

        var subscriptions = new List<NewSubscription>();
        var spotifySub = new NewSubscription
        {
            Icon = "spotify_logo.png",
            Title = "Spotify"
        };
        
        var oneDriveSub = new NewSubscription
        {
            Icon = "onedrive_logo.png",
            Title = "OneDrive"
        };
        
        var hboSubscription = new NewSubscription
        {
            Icon = "hbo_logo.png",
            Title = "HGBO GO"
        };
        

        spotifySub.Previous = hboSubscription;
        spotifySub.Next = oneDriveSub;

        oneDriveSub.Previous = spotifySub;
        oneDriveSub.Next = hboSubscription;

        hboSubscription.Previous = oneDriveSub;
        hboSubscription.Next = spotifySub;

        subscriptions.Add(spotifySub);
        subscriptions.Add(oneDriveSub);
        subscriptions.Add(hboSubscription);

        var vm = new AddSubscriptionViewModel(subscriptions);
		
        BindingContext = vm;
    }
}

public class AddSubscriptionViewModel
{
	public List<NewSubscription> Subscriptions { get; set; }

    public AddSubscriptionViewModel(List<NewSubscription> subscriptions)
    {
        Subscriptions = subscriptions;
    }
}

public class NewSubscription
{
	public string Icon { get; set; }
	public string Title { get; set; }

    public NewSubscription Previous { get; set; }
    public NewSubscription Next { get; set; }
}