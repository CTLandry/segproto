using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using seg.core.Models;

namespace seg.core.Services.RestServices.ShoppingListService
{
    public interface IShoppingListService
    {
        Task<IEnumerable<ShoppingList>> GetShoppingLists();
        Task CreateShoppingList(ShoppingList shoppingList);
    }
}
