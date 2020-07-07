using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using seg.core.Models;
using seg.core.Services.RestServices.ShoppingListService;
using Xamarin.Forms;

[assembly: Dependency(typeof(ShoppingListService))]
namespace seg.core.Services.RestServices.ShoppingListService
{
    public class ShoppingListService : IShoppingListService
    {
        public ShoppingListService()
        {
        }

        public Task CreateShoppingList(ShoppingList shoppingList)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ShoppingList>> GetShoppingLists()
        {
            //Temporary
            //Should call API for collection
            return await Task.Run(() =>
            {
                //temporary for effect
                var ShoppingLists = new List<ShoppingList>();
                var shoppingList1 = new ShoppingList("Shopping List 1");
                var shoppingList2 = new ShoppingList("Shopping List 2");

                ShoppingLists.Add(shoppingList1);
                ShoppingLists.Add(shoppingList2);

                return ShoppingLists;
            });
            
        }
    }
}
