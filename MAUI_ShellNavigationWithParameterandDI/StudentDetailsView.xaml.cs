using MAUI_ShellNavigationWithParameterandDI.ViewModels;

namespace MAUI_ShellNavigationWithParameterandDI;

public partial class StudentDetailsView : ContentPage
{
	public StudentDetailsView(StudentDetailsViewModel studentDetailsViewModel)
	{
		InitializeComponent();
		this.BindingContext = studentDetailsViewModel;
	}
}