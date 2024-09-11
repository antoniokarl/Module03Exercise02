using Microsoft.Maui.Controls;
using Module03Exercise01.Services;

namespace Module03Exercise01.View;

public partial class StartPage : ContentPage
{
	private readonly IMyService _myService; //Field for the Service
	public StartPage(IMyService myService)
	{
		InitializeComponent();
		_myService = myService;

		var message = _myService.GetMessage();
		MyLabel.Text = message;
	}
}