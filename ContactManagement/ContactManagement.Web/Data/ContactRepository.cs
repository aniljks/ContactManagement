using ContactManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagement.Web.Data
{    
    public class ContactRepository : IDisposable
    {
        private ContactDatabaseContext db = new ContactDatabaseContext();

        public IEnumerable<Contact> GetAll()
        {
            return db.Contact;
        }
        public Contact GetByID(int id)
        {
            return db.Contact.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Contact contact)
        {
            db.Contact.Add(contact);
            db.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
