using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookConsole
{
    public class Phonebook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();
        
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }

        private void DisplayContactDetails(Contact contact)
        {
            {
                Console.WriteLine($"Contact: {contact.Name} {contact.Number}");
            }
        }
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("No contact Found");
            }
            else
            {
               DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContacts()
        {
            foreach(var contact in _contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayMatchingContacts(string queryString)
        {
            var matchedContacts = _contacts.Where(c => c.Name.Contains(queryString)).ToList();
            foreach(var contact in matchedContacts)
            {
                DisplayContactDetails(contact);
            }
        }
    }
}
