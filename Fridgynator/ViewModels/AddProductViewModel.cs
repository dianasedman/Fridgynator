using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Fridgynator.Models;
using Microsoft.Maui.Storage;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Fridgynator.ViewModels;

public partial class AddProductViewModel: ObservableObject
{
    string title;
    string imageSource;
    string comment;
    private ObservableCollection<ProductsModel> productsList;

    public AddProductViewModel()
    {
        ProductsList = new ObservableCollection<ProductsModel>
        {
            new ProductsModel { ImageSource = "banana.png", Title = "Bananas" },
            new ProductsModel { ImageSource = "black_bread.png", Title = "Black bread" },
            new ProductsModel { ImageSource = "broccoli.png", Title = "Broccoli" },
            new ProductsModel { ImageSource = "cheese.png", Title = "Cheese" },
            new ProductsModel { ImageSource = "chicken.png", Title = "Chicken" },
            new ProductsModel { ImageSource = "cottage_cheese.png", Title = "Cottage cheese" },
            new ProductsModel { ImageSource = "cucumber.png", Title = "Cucumber" },
            new ProductsModel { ImageSource = "eggs.png", Title = "Eggs" },
            new ProductsModel { ImageSource = "fish.png", Title = "Fish" },
            new ProductsModel { ImageSource = "icecream.png", Title = "Ice cream" },
            new ProductsModel { ImageSource = "ketsup.png", Title = "Ketchup" },
            new ProductsModel { ImageSource = "lemon.png", Title = "Lemon" },
            new ProductsModel { ImageSource = "meat.png", Title = "Meat" },
            new ProductsModel { ImageSource = "milky.png", Title = "Milk" },
            new ProductsModel { ImageSource = "mustard.png", Title = "Mustard" },
            new ProductsModel { ImageSource = "pizza.png", Title = "Pizza" },
            new ProductsModel { ImageSource = "sausage.png", Title = "Sausage" },
            new ProductsModel { ImageSource = "shrimp.png", Title = "Shrimps" },
            new ProductsModel { ImageSource = "soup.png", Title = "Soup" },
            new ProductsModel { ImageSource = "water.png", Title = "Water" },
            new ProductsModel { ImageSource = "white_bread.png", Title = "White bread" },
        };
    }
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

    public ObservableCollection<ProductsModel> ProductsList
    {
        get => productsList;
        set => SetProperty(ref productsList, value);
    }


    //Saves products to fridge
    [RelayCommand]
    public async Task Save(ProductsModel product)
    {
        
        if (product != null)
        {
            
            product.Comment = Comment;   
            await App.ProductsRepository.AddProductAsync(product);

            await Toast.Make("Product has been added to the fridge!").Show();
        }
    }

    


}



