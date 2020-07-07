using seg.core.Services.RestServices.ShoppingListService;
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
            RegisterDependencies();
            MainPage = new NavigationPage(new ShoppingListOrganizerView());
        }

        private void RegisterDependencies()
        {
            DependencyService.Register<IShoppingListService, ShoppingListService>();
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
