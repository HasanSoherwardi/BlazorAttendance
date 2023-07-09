using System.Diagnostics;

namespace BlazorAttendance;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage (new MainPage());

	}



}
