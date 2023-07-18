namespace MAUI_ShellNavigationWithParameterandDI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
