using ModeloNavigation.Models;
using ModeloNavigation.UI.Utils;
using ModeloNavigation.UI.ViewModels;
using ModeloNavigation.UI.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ModeloNavigation.UI
{
    public class MasterPageViewModel : BaseViewModel
    {
        public ObservableCollection<PageType> Pages { get; }

        public Command NavigateCommand { get; }

        public MasterPageViewModel()
        {
            Pages = new ObservableCollection<PageType>();
            NavigateCommand = new AsyncCommand<ViewModelType>(ExecuteNavigateCommand);
            PopulateMaster();
        }

        async Task ExecuteNavigateCommand(ViewModelType arg)
        {
            try
            {
                await Navigate(arg);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message);
            }
        }

        async Task Navigate(ViewModelType type)
        {
            switch (type)
            {
                case ViewModelType.UmViewModel:
                    await Navigation.PushAsync<UmViewModel>(true);
                    break;
                case ViewModelType.DoisViewModel:
                    await Navigation.PushAsync<DoisViewModel>(true);
                    break;

                default:
                    return;
            }
        }

        void PopulateMaster()
        {
            try
            {
                var pages = new[]
                {
                    new PageType { Name = "Um Page", TypePage = ViewModelType.UmViewModel},
                    new PageType { Name = "Dois Page", TypePage = ViewModelType.DoisViewModel},
                };

                foreach (var item in pages)
                    Pages.Add(item);
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }
    }
}
