using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace People.ViewModels
{
    public class ViewModelBase : BindableBase, INavigatedAware
    {
        protected INavigationService _navigationService { get; private set; }

        public ViewModelBase(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        
        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
        }
    }
}
