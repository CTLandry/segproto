using System;
using System.Collections.Generic;
using seg.core.ViewModels;
using Xamarin.Forms;

namespace seg.core.Views
{
    public partial class ShoppingListOrganizerView : ContentPage
    {
        public ShoppingListOrganizerView()
        {
            InitializeComponent();
            this.BindingContext = new ShoppingListOrganizerViewModel();
        }
    }
}
