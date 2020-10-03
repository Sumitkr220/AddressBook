using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
	class AddressBook
	{
		public Dictionary<string,ContactDetails> addBook;
		public AddressBook()
		{
			this.addBook = new Dictionary<string, ContactDetails>();
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
			addBook.Add(firstName, contactObj);
		}
		public Dictionary<string, ContactDetails> ShowContact()
		{
			return addBook;
		}
		public string updateContact(string firstName,ContactDetails contact)
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
		public bool RemoveContact(String firstName)
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
	}
}
