using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using seg.core.Models;
using seg.core.Services.RestServices.ShoppingListService;
using Xamarin.Forms;

namespace seg.core.ViewModels
{
    public class ShoppingListOrganizerViewModel : _BaseViewModel
    {
       
        private IShoppingListService shoppingListService;

        private bool shoppingListLoaded = false;
        public bool ShoppingListLoaded
        {
            set { SetProperty(ref shoppingListLoaded, value); }
            get { return shoppingListLoaded; }
        }

        private IEnumerable<ShoppingList> shoppingLists = null;
        public IEnumerable<ShoppingList> ShoppingLists
        {
            set { SetProperty(ref shoppingLists, value); }
            get { return shoppingLists; }
        }

        public ShoppingListOrganizerViewModel()
        {
            shoppingListService = DependencyService.Get<IShoppingListService>();
            Task.Run(async () => await LoadShoppingList());
        }

        public async Task LoadShoppingList()
        {
           
                ShoppingLists = await shoppingListService.GetShoppingLists();
                shoppingListLoaded = true;
          
        }
    }
}
