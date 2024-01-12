namespace Fridgynator.Views;

public partial class Contacts : ContentPage
{
	public Contacts()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}