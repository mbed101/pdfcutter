using CommunityToolkit.Mvvm.ComponentModel;

namespace pdfcutter.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = "Welcome to Avalonia!";
    [ObservableProperty] private string _selectedFile = "";
    [ObservableProperty] private string _formula = "";
}