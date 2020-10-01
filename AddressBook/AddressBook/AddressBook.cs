using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
		public List<ContactDetails> addBook;
        public AddressBook()
        {
			this.addBook = new List<ContactDetails>();
        }
		public void setAddressBook(List<ContactDetails> contact)
		{
			this.addBook = contact;
		}
		public List<ContactDetails> getAddressBook()
		{
			return this.addBook;
		}
		public void addContact(ContactDetails contactObj)
		{
			addBook.Add(contactObj);
		}
		public List<ContactDetails> showContact()
		{
			return addBook;
		}
	}
}
