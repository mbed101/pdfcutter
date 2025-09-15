using System.IO;
using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using pdfcutter.ViewModels;
using pdfcutter.Classes;
namespace pdfcutter.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private async void ButtonSelectFile_OnClick(object? sender, RoutedEventArgs e)
    {
        var openFileDialog = new OpenFileDialog()
        {
            AllowMultiple = false,
            Title = "Select PDF file",
            Filters =
            {
                new FileDialogFilter { Name = "Pdf Files (*.pdf)|*.pdf", Extensions = { "pdf" } },
            }
        };
        var window=this.VisualRoot as Window;
        if (window is null)
        {
            return;
        }
        
        string[]? result = await openFileDialog.ShowAsync(window);
        if (result != null && result.Length > 0)
        {
            if (DataContext is MainViewModel vm)
            {
                vm.SelectedFile = result[0];
            }
        }
    }

    private void ButtonSplit_OnClick(object? sender, RoutedEventArgs e)
    {
        var pdf = new pdfcutter.Classes.Pdf();

        if (DataContext is MainViewModel vm)
        {
            var newFileName = Path.Combine(Path.GetDirectoryName(vm.SelectedFile) , Path.GetFileNameWithoutExtension(vm.SelectedFile))+ "_new.pdf";
            var result = pdf.exportSelectedPages(vm.SelectedFile,vm.Formula, newFileName);
            if (result)
            {
                var box= MessageBoxManager
                    .GetMessageBoxStandard("Done", "Successful",
                        ButtonEnum.Ok);
                box.ShowAsync();
            }
        }
        

    }
}