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
        // Create an instance of AddProductViewModel or obtain it from somewhere
        //AddProductViewModel viewModel = new AddProductViewModel();

        // Navigate to the Products page and pass the viewModel as a parameter
        await Navigation.PushAsync(new Products());
    }
    private async void NavigateToRecipes(object sender, EventArgs e)
    {
        // Navigate to another page
        await Navigation.PushAsync(new Recipes());
    }

    private async void NavigateToContacts(object sender, EventArgs e)
    {
        // Navigate to another page
        await Navigation.PushAsync(new Contacts());
    }
}