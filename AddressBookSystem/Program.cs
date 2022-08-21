using AddressBookSystem;
using System;

namespace Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book");


            AddressBookSystem.ContactOperation contactOperation = new ContactOperation();
            contactOperation.addContact("Shahrukh", "Khan", "Bandra", "Mumbai", "Maharashtra", "123345", "123456789", "srk@gmail.com");
            contactOperation.showList();

            Console.ReadKey();
        }
    }
}