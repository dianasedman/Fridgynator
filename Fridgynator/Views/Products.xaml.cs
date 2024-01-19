using Fridgynator.Models;
using Fridgynator.ViewModels;
using Microsoft.Maui.Storage;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Fridgynator.Views;

public partial class Products : ContentPage
{
    public ObservableCollection<ProductsModel> ProductsList { get; set; }

    public Products()
    {
        InitializeComponent(); 

        BindingContext = new AddProductViewModel();
    }

    async void BackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void NavigateTo_AddOwnProducts(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddOwnProducts());
    }

}

