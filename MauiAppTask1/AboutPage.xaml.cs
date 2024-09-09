namespace MauiAppTask1;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();

	}

    private async void OnNavigationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
    
}