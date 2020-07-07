using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seg.core.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace seg.core.Views.DataTemplates.ShoppingListOrganizer
{

    public partial class ShoppingListOrganizerDefaultView : Grid
    {
        private ShoppingList row;

        public ShoppingListOrganizerDefaultView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            row = (ShoppingList)BindingContext;
        }
    }
}
