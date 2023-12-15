using Fridgynator.Models;

namespace Fridgynator.Views;

public partial class RecipesPage : ContentPage
{
	public RecipesPage()
	{
		InitializeComponent();
	}

	

	async void ApiPic_Clicked(System.Object sender, System.EventArgs e)
	{

	}

	async void GridArea_Tapped(System.Object sender, System.EventArgs e)
	{

	}

	async void Recipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		await Navigation.PushAsync(new RecipesDetailsPage(e.CurrentSelection.First() as Recipes));
	}
}
