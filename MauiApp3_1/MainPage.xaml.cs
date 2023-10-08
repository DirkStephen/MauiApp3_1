

namespace MauiApp3_1;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
	async void OnDial(object sender, EventArgs e)
	{
		try
		{
			PhoneDialer.Open(PhoneNum.Text);
		}
		catch
		{
			await DisplayAlert("Invalid Input", "Please enter a valid phone number", "OK");
		}
	}
	
}

