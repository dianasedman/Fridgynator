using Fridgynator.ViewModels;

namespace Fridgynator.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private async void NavigateToFridge(object sender, EventArgs e)
    {
        FridgeViewModel viewModel = new FridgeViewModel();
        // Navigate to another page
        await Navigation.PushAsync(new Fridge(viewModel));
    }

    private async void NavigateToProducts(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Products());
    }
    private async void NavigateToRecipes(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Recipes());
    }

    private async void NavigateToContacts(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Contacts());
    }
}