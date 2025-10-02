using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMauiMobileApp.ViewModel
{
    public class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private string title = TitleMain.Title;
        [ObservableProperty]
        private string layouts = TitleMain.Layouts;
        [ObservableProperty]
        private string images = TitleMain.Images;
        [ObservableProperty]
        private string collections = TitleMain.Collections;
        [ObservableProperty]
        private string controls = TitleMain.Controls;
        [ObservableProperty]
        private string sql_lite = TitleMain.SQL_Lite;

        //public ICommand OnLayoutsClicked { get; set; }

        public MainViewModel() 
        {
        
        }

        [RelayCommand]
        private async void LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

    }
}
