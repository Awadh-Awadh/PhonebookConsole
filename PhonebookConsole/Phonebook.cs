using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookConsole
{
    public class Phonebook
    {
        private List<Contact> _contacts { get; set; }
        
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact != null)
            {
                Console.WriteLine("No contact Found");
            }
            else
            {
                Console.WriteLine($"Contact: {contact.Name} {contact.Number}")
            }
        }
    }
}
