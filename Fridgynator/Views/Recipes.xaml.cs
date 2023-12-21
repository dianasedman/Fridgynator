using System.Numerics;
using Fridgynator.Models;
using Fridgynator.Services;

namespace Fridgynator.Views;


public partial class Recipes : ContentPage
{
	public Recipes()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		lstPopularRecipes.ItemsSource = RecipesService.GetFeaturedRecipes();
		lstAllRecipes.ItemsSource = RecipesService.GetAllRecipes();
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