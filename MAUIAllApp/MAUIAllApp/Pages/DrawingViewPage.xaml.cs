namespace MAUIAllApp;

public partial class DrawingViewPage : ContentPage
{
	public DrawingViewPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Clear();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Clear();
    }

    void Clear()
    {
        DrawView.Lines.Clear();
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        DrawView.LineWidth = (float)(e.NewValue * 50);
    }
}