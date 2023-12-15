namespace Fridgynator.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();

	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransitionAnimation"))
        {
            return;
        }

        var parentAnimation = new Animation();

        //Products Animation
        parentAnimation.Add(0, 0.2, new Animation(v => imgeggs.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.1, 0.3, new Animation(v => imgketsup.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.2, 0.4, new Animation(v => imgcheese.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.3, 0.5, new Animation(v => imgmustard.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.4, 0.6, new Animation(v => imgmilky.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimation.Add(0.5, 0.7, new Animation(v => imgsausage.Opacity = v, 0, 1, Easing.CubicIn));

        //Rotation
        parentAnimation.Add(0, 1, new Animation(v => imgeggs.Rotation = v * 360, 0, 1));
        parentAnimation.Add(0, 1, new Animation(v => imgketsup.Rotation = v * 360, 0, 1));
        parentAnimation.Add(0, 1, new Animation(v => imgcheese.Rotation = v * 360, 0, 1));
        parentAnimation.Add(0, 1, new Animation(v => imgmustard.Rotation = v * 360, 0, 1));
        parentAnimation.Add(0, 1, new Animation(v => imgmilky.Rotation = v * 360, 0, 1));
        parentAnimation.Add(0, 1, new Animation(v => imgsausage.Rotation = v * 360, 0, 1));


        parentAnimation.Commit(this, "TransitionAnimation", 16, 3000, null, null);
    }
    private void OnButtonClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Menu());
    }
}