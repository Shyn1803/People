using Prism;
using Prism.Ioc;
using People.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using People.Services;
using People.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace People
{
    public partial class App
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("Navigation/PeopleListPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IDataService, MockDataService>();

            containerRegistry.RegisterForNavigation<NavigationPage>("Navigation");
            containerRegistry.RegisterForNavigation<PeopleListPage, PeopleListPageViewModel>();
            containerRegistry.RegisterForNavigation<EditPage>("Edit");
            
        }
    }
}
