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

			Console.WriteLine("Update contact: Enter name and all the details to update");
			Console.WriteLine("Enter first name: ");
			string firstName1 = Console.ReadLine();
			Console.WriteLine("Enter last name: ");
			string lastName1 = Console.ReadLine();
			Console.WriteLine("Enter address: ");
			string address1 = Console.ReadLine();
			Console.WriteLine("Enter city: ");
			string city1 = Console.ReadLine();
			Console.WriteLine("Enter state: ");
			string state1 = Console.ReadLine();
			Console.WriteLine("Enter zip: ");
			string zipcode1 = Console.ReadLine();
			Console.WriteLine("Enter phone number: ");
			string phone1 = Console.ReadLine();
			Console.WriteLine("Enter email: ");
			string email1 = Console.ReadLine();

			ContactDetails contact1 = new ContactDetails(firstName1, lastName1, address1, city1, state1, zipcode1, phone1, email1);
			string check=addressBook.updateContact(contact1,contact);
			if (check.Equals("yes"))
			{
				List<ContactDetails> contDet1 = new List<ContactDetails>();
				contDet1 = addressBook.showContact();
				foreach (ContactDetails item in contDet1)
				{
					Console.WriteLine(contact1.toString());
				}
                Console.WriteLine("Update Successfully");
			}
			else
                Console.WriteLine("No contact to update");
		}
	}
}
	


