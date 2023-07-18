using CommunityToolkit.Mvvm.Input;
using MAUI_ShellNavigationWithParameterandDI.Models;
using MAUI_ShellNavigationWithParameterandDI.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MAUI_ShellNavigationWithParameterandDI.ViewModels
{
    public partial class StudentListViewModel : BaseViewModel
    {
        #region Properites
        public ObservableCollection<Student> StudentList { get; set; } = new ObservableCollection<Student>();
        public IStudentService _studentService;
        #endregion


        public StudentListViewModel(IStudentService studentService)
        {
            this._studentService = studentService;
            AddStudentList();
        }

        private void AddStudentList()
        {
            IsBusy = true;
            
            Task.Run(async () =>
            {
              var students = await _studentService.GetAllStudents();
                Application.Current.Dispatcher.Dispatch(() =>
                {
                    StudentList.Clear();
                    if (students != null)
                    {
                        foreach(var student in students)
                        {
                            StudentList.Add(student);
                        }
                        IsBusy = false;
                    }
                });
            });
        }

        #region Commands

        [RelayCommand]
        public void Refresh()
        {
            IsRefreshing = false;
            AddStudentList();
        }

        [RelayCommand]
        public async Task SelectedItem(Student studentDetail)
        {
            var navparam = new Dictionary<string, object>
            {
                {"StudentDetail",studentDetail }
            };
            await AppShell.Current.GoToAsync(nameof(StudentDetailsView), navparam);
        }
        #endregion

        //public ICommand RefreshCommand => new Command(async () =>
        //{
        //    IsRefreshing = false;
        //    AddStudentList();
        //});

        //public ICommand SelectedItemCommand => new Command<Student>(async (studentDetail) =>
        //{
        //    //await App.Current.MainPage.DisplayAlert("Selected Student", "Selected Student Name is " + studentDetail.name, "OK");
        //    var navparam = new Dictionary<string, object>
        //    {
        //        {"StudentDetail",studentDetail }
        //    };
        //    await AppShell.Current.GoToAsync(nameof(StudentDetailsView), navparam);
        //});
    }
}
