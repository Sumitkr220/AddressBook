using System;
using System.Collections.Generic;
using System.Dynamic;

namespace AddressBook
{
	class Program
	{
		static void Main(string[] args)
		{
			AddressBook addressBook = new AddressBook();

			Console.WriteLine("Welome to Address Book!!!");
			Console.WriteLine("Enter first name: ");
			string firstName = Console.ReadLine();
			Console.WriteLine("Enter last name: ");
			string lastName = Console.ReadLine();
			Console.WriteLine("Enter address: ");
			string address = Console.ReadLine();
			Console.WriteLine("Enter city: ");
			string city = Console.ReadLine();
			Console.WriteLine("Enter state: ");
			string state = Console.ReadLine();
			Console.WriteLine("Enter zip: ");
			string zipcode = Console.ReadLine();
			Console.WriteLine("Enter phone number: ");
			string phone = Console.ReadLine();
			Console.WriteLine("Enter email: ");
			string email = Console.ReadLine();

			ContactDetails contact = new ContactDetails(firstName, lastName, address, city, state, zipcode, phone, email);
			addressBook.addContact(contact);
			List<ContactDetails> contDet = new List<ContactDetails>();
		    contDet = addressBook.showContact();
			foreach (ContactDetails item in contDet)
			{
				Console.WriteLine(contact.toString());
			}
		}
	}
}
	


