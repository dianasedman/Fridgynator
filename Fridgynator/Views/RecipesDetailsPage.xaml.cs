using Fridgynator.Models;

namespace Fridgynator.Views;

public partial class RecipesDetailsPage : ContentPage
{
	public RecipesDetailsPage(Models.Recipes recipes)
	{
		InitializeComponent();
		this.BindingContext = recipes;

	}


	async void BackButton_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}