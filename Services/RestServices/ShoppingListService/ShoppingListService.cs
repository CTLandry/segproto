using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using seg.core.Models;

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

        public Task<IEnumerable<ShoppingList>> GetShoppingLists()
        {
            throw new NotImplementedException();
        }
    }
}
