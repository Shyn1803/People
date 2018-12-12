using People.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace People.Services
{
    public interface IDataService
    {
        Task<ObservableCollection<Contact>> GetContacts();

        Task AddNewContact(Contact contact);
    }
}
