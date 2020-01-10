using ContactManagement.Web.Models;
using System.Collections.Generic;

namespace ContactManagement.Web.Service
{
    public interface IContactService
    {
        IEnumerable<ContactViewModel> GetAll();
        ContactViewModel GetById(int id);
        bool Create(ContactViewModel model);
        bool Update(ContactViewModel model);
        bool Delete(int id);

    }
}