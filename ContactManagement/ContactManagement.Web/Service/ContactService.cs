using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManagement.Web.Data;
using ContactManagement.Web.Models;

namespace ContactManagement.Web.Service
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _repository;
        public ContactService(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public bool Create(ContactViewModel model)
        {
            bool isCreated = false;
            try
            {
                _repository.Insert(Adapter.ContactEntityModelAdapter.ContactViewModelToContactEntity(model));
                isCreated = true;
            }
            catch (Exception e)
            {
                isCreated = false;
            }
            return isCreated;
        }

        public bool Delete(int id)
        {
            bool isDeleted = false;
            try
            {
                ContactViewModel model = new ContactViewModel();
                model = Adapter.ContactEntityModelAdapter.ContactEntityToContactViewModel(_repository.Get(id));
                if (model != null)
                    _repository.Delete(Adapter.ContactEntityModelAdapter.ContactViewModelToContactEntity(model));

                isDeleted = true;
            }
            catch (Exception ex)
            {
                isDeleted = false;
            }

            return isDeleted;
        }

        public IEnumerable<ContactViewModel> GetAll()
        {
            List<ContactViewModel> contacts = new List<ContactViewModel>();
            foreach (var item in _repository.GetAll().Where(x=>x.Status == true))
            {
                contacts.Add(Adapter.ContactEntityModelAdapter.ContactEntityToContactViewModel(item));
            }

            return contacts;
        }

        public ContactViewModel GetById(int id)
        {
            ContactViewModel model = new ContactViewModel();
            model = Adapter.ContactEntityModelAdapter.ContactEntityToContactViewModel(_repository.Get(id));
            return model;
        }

        public bool Update(ContactViewModel model)
        {
            bool isUpdated = false;
            try
            {
                _repository.Update(Adapter.ContactEntityModelAdapter.ContactViewModelToContactEntity(model));
                isUpdated = true;
            }
            catch (Exception ex)
            {
                throw ex;                
                //Need to log it here             

            }
            return isUpdated;
        }
    }
}
