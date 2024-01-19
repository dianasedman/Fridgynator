using Fridgynator.ViewModels;

namespace Fridgynator.Views;

public partial class Fridge : ContentPage
{
	FridgeViewModel viewModel;
	public Fridge(FridgeViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = this.viewModel = viewModel;
	}

    protected override void OnAppearing()
    {
		base.OnAppearing();
		viewModel.GetProductsItemsCommand.Execute(null);
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

   



}