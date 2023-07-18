using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MAUI_ShellNavigationWithParameterandDI.ViewModels
{
    //public class BaseViewModel : INotifyPropertyChanged
    //{
    //    private bool _isBusy;
    //    public bool IsBusy
    //    {
    //        get => _isBusy;
    //        set => SetProperty(ref _isBusy, value);
    //    }

    //    private bool _isRefreshing;
    //    public bool IsRefreshing
    //    {
    //        get => _isRefreshing;
    //        set => SetProperty(ref _isRefreshing, value);
    //    }

    //   protected bool SetProperty<T>(ref T backingStore, T value,
    //   [CallerMemberName] string propertyName = "",
    //   Action onChanged = null)
    //    {
    //        if (EqualityComparer<T>.Default.Equals(backingStore, value))
    //            return false;

    //        backingStore = value;
    //        onChanged?.Invoke();
    //        OnPropertyChanged(propertyName);
    //        return true;
    //    }

    //    #region INotifyPropertyChanged
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    //    {
    //        var changed = PropertyChanged;
    //        if (changed == null)
    //            return;

    //        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //    #endregion
    //}

    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        public bool isBusy;

        [ObservableProperty]
        public bool isRefreshing;
    }
}
