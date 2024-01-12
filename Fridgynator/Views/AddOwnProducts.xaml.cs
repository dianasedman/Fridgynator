namespace Fridgynator.Views;

public partial class AddOwnProducts : ContentPage
{
	public AddOwnProducts()
	{
		InitializeComponent();
	}
    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}