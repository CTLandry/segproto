using System;
namespace seg.core.Models
{
    public class ShoppingList : _BaseModel
    {
        private string name = null;
        public string Name
        {
            set { SetProperty(ref name, value); }
            get { return name; }
        }

        public ShoppingList(string name)
        {
        }
    }
}
