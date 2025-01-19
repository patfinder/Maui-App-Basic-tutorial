namespace MauiApp2.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private void LearnMore_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Clicked!", "You clicked the button!", "OK");
    }
}