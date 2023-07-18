using CommunityToolkit.Mvvm.ComponentModel;
using MAUI_ShellNavigationWithParameterandDI.Models;

namespace MAUI_ShellNavigationWithParameterandDI.ViewModels
{
    [QueryProperty(nameof(StudentDetail), "StudentDetail")]
    public partial class StudentDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student studentDetail;
    }
}
