using Fridgynator.Models;
using Fridgynator.ViewModels;
using Microsoft.Maui.Storage;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace Fridgynator.Views;

public partial class Products : ContentPage
{
    private string fileName;

    public ObservableCollection<ProductsModel> ProductsList { get; set; }

    public Products()
    {
        InitializeComponent();

       

        BindingContext = new AddProductViewModel();

    }

    //private void OnSaveButtonClicked(object sender, EventArgs e)
    //{
    //    // Serialize and save ProductsList to fridge.xaml file
    //    _ = SaveProductsListToFileAsync("Fridge.xaml");
    //}

    //private async Task SaveProductsListToFileAsync(string filePath)
    //{
    //    try
    //    {


    //        var productItem = new ProductsModel
    //        {
    //            Title = Title,
    //            ImageSource = ImageSource

    //        };

    //        await App.ProductsRepository.AddProductAsync(productItem);

    //        await Toast.Make("Product has been added to fridge!").Show();


    //    }
    //    catch (Exception ex)
    //    {
    //        // Handle exception, e.g., display an error message
    //        await Toast.Make($"Error saving ProductsList: {ex.Message}").Show();

    //    }
    //}


    ////private void OnLoadButtonClicked(object sender, EventArgs e)
    ////{
    ////    // Deserialize and load ProductsList from fridge.xaml file
    ////    LoadProductsListFromFile("fridge.xaml");
    ////}



    //private void LoadProductsListFromFile(string filePath)
    //{
    //    try
    //    {
    //        using (var stream = new FileStream(filePath, FileMode.Open))
    //        {
    //            var serializer = new XmlSerializer(typeof(List<ProductsModel>), new XmlRootAttribute("ProductsList"));
    //            ProductsList = new ObservableCollection<ProductsModel>((List<ProductsModel>)serializer.Deserialize(stream));
    //        }

    //        // Optionally update UI or perform additional actions after loading
    //        DisplayAlert("Load", "ProductsList loaded successfully!", "OK");
    //    }
    //    catch (Exception ex)
    //    {
    //        // Handle exception, e.g., display an error message
    //        DisplayAlert("Error", $"Error loading ProductsList: {ex.Message}", "OK");
    //    }
    //}
}

