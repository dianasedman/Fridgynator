namespace Fridgynator.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();

	}
    private void OnButtonClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Products());
    }
}