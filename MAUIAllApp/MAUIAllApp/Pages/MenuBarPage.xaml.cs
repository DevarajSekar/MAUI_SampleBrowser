namespace MAUIAllApp;

public partial class MenuBarPage : ContentPage
{
	private uint AnimationDuration = 300;
	public MenuBarPage()
	{
		InitializeComponent();
	}

	private async void Menu_Tapped(object sender, EventArgs e)
	{
		_ = MainGrid.TranslateTo(this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
		await MainGrid.ScaleTo(0.8, AnimationDuration);
		_ = MainGrid.FadeTo(0.8, AnimationDuration);
	}

	private async void Close_Tapped(object sender, EventArgs e)
	{
		_ = MainGrid.FadeTo(1, AnimationDuration);
		_= MainGrid.ScaleTo(1, AnimationDuration);
		await MainGrid.TranslateTo(0, 0, AnimationDuration, Easing.CubicIn);
	}
}