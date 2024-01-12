using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fridgynator.Models;
using System.Collections.ObjectModel;


namespace Fridgynator.ViewModels;

public partial class FridgeViewModel : ObservableObject
{
    private string title;
    private string imageSource;

    ObservableCollection<ProductsModel> productItems;

    public string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    public string ImageSource
    {
        get => imageSource;
        set => SetProperty(ref imageSource, value);
    }

    public ObservableCollection<ProductsModel> ProductItems
    {
        get => productItems;
        set => SetProperty(ref productItems, value);
    }
    public FridgeViewModel()
    {
        ProductItems = new ObservableCollection<ProductsModel>();
    }

    [RelayCommand]
    public async Task GetProductsItems()
    {
        var rawData = await App.ProductsRepository.GetAllProductsAsync();
        MapToObservableCollection(rawData);
    }

    private void MapToObservableCollection(List<ProductsModel> products)
    {
        ProductItems.Clear();
        foreach (var product in products)
        {
            ProductItems.Add(product);
        }
    }

    //Deletes items from fridge

    [RelayCommand]
    public async Task Delete(ProductsModel product)
    {
        if (product != null)
        {
            ProductItems.Remove(product);
            await App.ProductsRepository.DeleteProductAsync(product);
        }
    }
}
