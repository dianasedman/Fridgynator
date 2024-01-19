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

    public void Entry_Completed(object sender, FocusEventArgs e)
    {
        var entry = sender as Entry;
        if (entry != null)
        {
            // Saage kommentaari v‰‰rtus
            var comment = entry.Text;

            SaveCommentToDatabase(comment);

        }
    }

    private async void SaveCommentToDatabase(string comment)
    {
        // N‰iteks, salvestage kommentaar andmebaasis, kasutades teie rakenduse andmehaldurit vıi muud teenust
        // N‰iteks: await App.CommentRepository.SaveCommentAsync(comment);

        // Kui kommentaar on salvestatud, vıite ka teavitada kasutajat edukast salvestamisest
        await DisplayAlert("Success", "Comment saved successfully", "OK");
    }


}