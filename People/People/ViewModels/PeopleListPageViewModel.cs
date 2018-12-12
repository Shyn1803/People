using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using People.Models;
using People.Services;
using Prism.Commands;
using Prism.Navigation;

namespace People.ViewModels
{
    public class PeopleListPageViewModel : ViewModelBase
    {
        private IDataService _dataService;
        private ObservableCollection<Contact> _contacts;

        public PeopleListPageViewModel(INavigationService navigationService, IDataService dataService) : base(navigationService)
        {
            _dataService = dataService;
            NewCommand = new DelegateCommand(NewExcute);
        }

        private void NewExcute()
        {
            _navigationService.NavigateAsync("Edit");       //Chuyen den trang them nguoi dung vao danh ba
        }

        public ICommand NewCommand { get; set; }

        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set => SetProperty(ref _contacts, value);
        }
        public override async void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (Contacts != null && Contacts.Any())
                return;

            Contacts = await _dataService.GetContacts();
        }
        
    }
}
