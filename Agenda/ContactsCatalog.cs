using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    public class ContactsCatalog
    {
        private Dictionary<int, Contact> Catalog = new Dictionary<int, Contact> { };
        private static int num = 1;
  

        public ContactsCatalog()
        {
            // fill catalog with some contacts
            Catalog.Add(num++, new Contact("Nikos", "Nikolaou", "6911111111"));
            Catalog.Add(num++, new Contact("Petros", "Petrou", "6922222222"));
            Catalog.Add(num++, new Contact("Xristos", "Xristou", "6933333333"));
            Catalog.Add(num++, new Contact("Ioannis", "Ioannou", "6944444444"));
            Catalog.Add(num++, new Contact("Giorgos", "Georgiou", "6911111111"));
        }

        public void SetNewContact(string fname, string lname, string mphone)
        {
            Catalog.Add(num++, new Contact(fname, lname, mphone));
        }

        public List<Contact> GetAllContacts()
        {
            List<Contact> AllContacts = new List<Contact> { };
            AllContacts = Catalog.Select(s => s.Value).ToList();
            return AllContacts;
        }

        public Contact GetASpecificContact(int key)
        {
            if (Catalog.ContainsKey(key))
            {
                return Catalog[key];
            }
            else return null;
        }



    }
}
