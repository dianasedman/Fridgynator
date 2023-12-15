using Fridgynator.Models;
using System.Collections.ObjectModel;

namespace Fridgynator.Views;

public partial class Products : ContentPage
{
    public ObservableCollection<ProductsModel> ProductsList { get; set; }

    public Products()
    {
        InitializeComponent();

        ProductsList = new ObservableCollection<ProductsModel>
            {
                new ProductsModel { ImageSource = "bananas.png", Title = "Bananas" },
                new ProductsModel { ImageSource = "cheese.png", Title = "Cheese" },
                new ProductsModel { ImageSource = "eggs.png", Title = "Eggs" },
                new ProductsModel { ImageSource = "meat.png", Title = "Meat" },
                new ProductsModel { ImageSource = "mustard.png", Title = "Mustard" },
            };

        BindingContext = this;

    }
}