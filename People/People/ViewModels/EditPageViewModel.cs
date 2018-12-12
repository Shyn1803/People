using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using People.Models;
using People.Services;
using Prism.Commands;
using Prism.Navigation;

namespace People.ViewModels
{
    public class EditPageViewModel : ViewModelBase
    {
        private Contact _contact;
        private IDataService _dataService;

        public EditPageViewModel(INavigationService navigationService, IDataService dataService) : base(navigationService)
        {
            _dataService = dataService;
            SaveCommand = new DelegateCommand(SaveExcute);
        }

        public Contact Contact
        {
            get => _contact;
            set => SetProperty(ref _contact, value);
        }
        private void SaveExcute()
        {
            _dataService.AddNewContact(Contact);

            _navigationService.GoBackAsync();   //sau khi them xong nguoi dung thi tro ve trang truoc
        }
        public ICommand SaveCommand { get; set; }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            Contact = new Contact();
        }
    }
}
