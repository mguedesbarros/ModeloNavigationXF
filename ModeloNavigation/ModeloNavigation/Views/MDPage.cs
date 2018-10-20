using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ModeloNavigation.UI.Views
{
    public class MDPage : MasterDetailPage
    {
        ViewModels.UmViewModel Vm = new ViewModels.UmViewModel();

        public MDPage()
        {
            Detail = new NavigationPage(new UmPage() { BindingContext = Vm });
            Master = new MasterPage();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await Vm.InitializeAsync(null);
        }
    }
}
