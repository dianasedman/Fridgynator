﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fridgynator.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Fridgynator.ViewModels;

public partial class FridgeViewModel : ObservableObject
{
    private string title;
    private string imageSource;
    private string comment;

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

    public string Comment
    {
        get => comment;
        set => SetProperty(ref comment, value);
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
            Debug.WriteLine( product.Comment);
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
