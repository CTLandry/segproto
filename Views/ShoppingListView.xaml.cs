using System;
using System.Collections.Generic;
using seg.core.ViewModels;

using Xamarin.Forms;

namespace seg.core.Views
{
    public partial class ShoppingListView : ContentPage
    {
        public ShoppingListView()
        {
            InitializeComponent();
            BindingContext = new ShoppingListViewModel();
        }
    }
}
