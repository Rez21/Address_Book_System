using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
   
    
        public class ContactOperation
        {
            private List<ContactInformation> ContactList;
            public ContactOperation()
            {
                this.ContactList = new List<ContactInformation>();
            }

            public void addContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
            {
                ContactInformation newContact = new ContactInformation(firstName, lastName, address, city, state, zip, phoneNumber, email);
                this.ContactList.Add(newContact);
            }
            public void showList()
            {
                foreach (var contact in ContactList)
                {
                    Console.WriteLine("FirstName: " + contact.FirstName);
                    Console.WriteLine("LastName: " + contact.LastName);
                    Console.WriteLine("Address: " + contact.Address);
                    Console.WriteLine("City: " + contact.City);
                    Console.WriteLine("State: " + contact.State);
                    Console.WriteLine("ZipCode: " + contact.Zip);
                    Console.WriteLine("Phone Number: " + contact.PhoneNumber);
                    Console.WriteLine("Email: " + contact.Email);
                    Console.WriteLine("-----------------");

                }
            }
        }
}
