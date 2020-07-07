using Xamarin.Forms;

namespace seg.core.Views.DataTemplates.ShoppingListOrganizer
{
    public class ShoppingListDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Default { get; set; }
        public DataTemplate Editing { get; set; }
        public DataTemplate Emoji { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            switch (((Models.ShoppingList)item).ListState)
            {
                case Models.ShoppingList.ShoppingListState.Emoji:
                    {
                        return Emoji;
                    }
                case Models.ShoppingList.ShoppingListState.Editing:
                    {
                        return Editing;
                    }
                default:
                    {
                        return Default;
                    }
            }
        }
    }
}
