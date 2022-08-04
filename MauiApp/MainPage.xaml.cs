using InvokePlatformCodeDemos.Services.PartialMethods;

namespace MauiApp;

public partial class MainPage : ContentPage
{
	DeviceOrientationService service;
    int count = 0;

	public MainPage()
	{
		InitializeComponent();
        service = new DeviceOrientationService();

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		string orientation = service.GetOrientation().ToString();


        if (count == 1)
			CounterBtn.Text = $"Clicked {count} time - orientation = {orientation}";
		else
			CounterBtn.Text = $"Clicked {count} times - orientation = {orientation}";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

