using ContactManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Web.Adapter
{
    public class ContactEntityModelAdapter
    {
        public static Contact ContactViewModelToContactEntity(ContactViewModel model)
        {
            Contact contact = new Contact();
            contact.Email = model.Email;
            contact.FirstName = model.FirstName;
            contact.Id = model.Id;
            contact.LastName = model.LastName;
            contact.Phone = model.Phone;
            contact.Status = model.Status == Status.Active ? true : false;
            return contact;
        }

        public static ContactViewModel ContactEntityToContactViewModel(Contact contact)
        {
            ContactViewModel model = new ContactViewModel();
            model.Email = contact.Email;
            model.FirstName = contact.FirstName;
            model.Id = contact.Id;
            model.LastName = contact.LastName;
            model.Phone = contact.Phone;
            Status status;
            //Enum.TryParse<Status>(contact.Status.ToString(), out status);
            if (contact.Status == true)
                status = Status.Active;
            else
                status = Status.Deactive;

            model.Status = status;
            return model;
        }
    }
}
