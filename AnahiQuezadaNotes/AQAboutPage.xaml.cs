namespace AnahiQuezadaNotes;

public partial class AQAboutPage : ContentPage
{
	public AQAboutPage()
	{
		InitializeComponent();
	}
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}