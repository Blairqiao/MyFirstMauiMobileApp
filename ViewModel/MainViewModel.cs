﻿using MyFirstMauiMobileApp.Model.Titles;
using MyFirstMauiMobileApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMauiMobileApp.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        public string Layouts { get; set; } = TitleMain.Layouts;
        public string Images { get; set; } = TitleMain.Images;
        public string Collections { get; set; } = TitleMain.Collections;
        public string Controls { get; set; } = TitleMain.Controls;
        public string SQL_Lite { get; set; } = TitleMain.SQL_Lite;

        public ICommand OnLayoutsClicked { get; set; }
        public MainViewModel() 
        {
        
            Title = TitleMain.Title;

            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);

        }

        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }

    }
}
