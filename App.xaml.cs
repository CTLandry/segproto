using seg.core.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace seg.core
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();
            var shoppingView = new ShoppingListOrganizerView();
            MainPage = shoppingView;
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}
