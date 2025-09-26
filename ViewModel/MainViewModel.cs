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
    public class MainViewModel : BaseViewModel
    {

        public string Layouts { get; set; } = TitleMain.Layouts;

        public ICommand OnLayoutsClicked { get; set; }
        public MainViewModel() {
        
            Title = TitleMain.Title;

            //commands
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);

        }

        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LayoutsPage());
        }

    }
}
