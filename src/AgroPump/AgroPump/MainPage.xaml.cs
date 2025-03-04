namespace AgroPump;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCardTapped(object sender, EventArgs e)
    {
        await DisplayAlert("Tapped", "Card was tapped", "OK");
    }
} 