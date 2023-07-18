namespace MAUI_ShellNavigationWithParameterandDI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(StudentDetailsView), typeof(StudentDetailsView));
	}
}
