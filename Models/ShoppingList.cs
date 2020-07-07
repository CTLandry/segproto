using System;
namespace seg.core.Models
{
    public class ShoppingList : _BaseModel
    {
        public enum ShoppingListState
        {
            Default,
            Editing,
            Emoji
        }

        private string name = null;
        public string Name
        {
            set { SetProperty(ref name, value); }
            get { return name; }
        }

        private ShoppingListState listState; 
        public ShoppingListState ListState
        {
            set { SetProperty(ref listState, value); }
            get { return listState; }
        }

        public ShoppingList(string name)
        {
            Name = name;
            ListState = ShoppingListState.Default;
        }
    }
}
