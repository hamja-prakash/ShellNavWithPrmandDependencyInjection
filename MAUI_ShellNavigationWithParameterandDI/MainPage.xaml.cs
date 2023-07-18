using MAUI_ShellNavigationWithParameterandDI.Services;
using MAUI_ShellNavigationWithParameterandDI.ViewModels;

namespace MAUI_ShellNavigationWithParameterandDI;

public partial class MainPage : ContentPage
{
	public MainPage(StudentListViewModel studentListViewModel)
	{
		InitializeComponent();
		this.BindingContext = studentListViewModel;
    }
}

