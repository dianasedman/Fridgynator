using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fridgynator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridgynator.ViewModels;

public partial class FridgeViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<ProductsModel> productItems;

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
}
