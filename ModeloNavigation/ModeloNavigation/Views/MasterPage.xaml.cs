﻿using ModeloNavigation.Models;
using ModeloNavigation.UI.ViewModels;
using Xamarin.Forms;

namespace ModeloNavigation.UI
{
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            BindingContext = new MasterPageViewModel();
        }

        void PageList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (!(e.Item is PageType pt)) return;

            (BindingContext as MasterPageViewModel).NavigateCommand.Execute(pt.TypePage);


            ((ListView)sender).SelectedItem = null;
        }
    }
}
