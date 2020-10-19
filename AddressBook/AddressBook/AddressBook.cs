using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AddressBook
{
	class AddressBook
	{
		public Dictionary<string, ContactDetails> addBook;
		public List<ContactDetails> addContact;

		public AddressBook()
		{
			this.addBook = new Dictionary<string, ContactDetails>();
			this.addContact = new List<ContactDetails>();
		}
		public void setAddressBook(Dictionary<string, ContactDetails> contact)
		{
			this.addBook = contact;
		}
		public Dictionary<string, ContactDetails> getAddressBook()
		{
			return this.addBook;
		}
		public void AddContact(string firstName, ContactDetails contactObj)
		{
			try
			{
				addBook.Add(firstName, contactObj);
				addContact.Add(contactObj);
			}
			catch
			{
				Console.WriteLine("Can not add duplicate name");
			}

		}
		public List<ContactDetails> getContact()
		{
			return addContact;
		}
		public Dictionary<string, ContactDetails> ShowContact()
		{
			return addBook;
		}
		public string updateContact(string firstName, ContactDetails contact)
		{
			int count = 0;
			foreach (KeyValuePair<string, ContactDetails> item in addBook)
			{
				if (item.Key.Equals(firstName))
				{
					addBook.Remove(item.Key);
					count++;
				}
			}
			if (count == 0)
			{
				return "no";
			}
			else
			{
				addBook.Add(firstName, contact);
				return "yes";
			}
		}
		public bool RemoveContact(string firstName)
		{
			ContactDetails contact = new ContactDetails("", "", "", "", "", "", "", "");
			foreach (KeyValuePair<string, ContactDetails> item in addBook)
			{
				if (item.Key.Equals(firstName))
				{
					contact = item.Value;
				}
			}
			return addBook.Remove(firstName);
		}

		public List<String> searchContactByCity(string city)
		{
			List<String> list = new List<string>();
			foreach (ContactDetails contact in addContact.FindAll(e => (e.city.Equals(city))).ToList())
			{
				list.Add(contact.firstName);
			}
			return list;
		}
		public List<String> searchContactByState(string state)
		{
			List<String> list = new List<string>();
			foreach (ContactDetails contact in addContact.FindAll(e => (e.city.Equals(state))).ToList())
			{
				list.Add(contact.firstName);
			}
			return list;
		}
	}
}
