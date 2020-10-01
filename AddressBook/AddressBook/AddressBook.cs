using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class AddressBook
    {
		private LinkedList<ContactDetails> addBook;
        public AddressBook()
        {
			this.addBook = new LinkedList<ContactDetails>();
        }
		public void setAddressBookBuilder(LinkedList<ContactDetails> contact)
		{
			this.addBook = contact;
		}
		public LinkedList<ContactDetails> getAddressBook()
		{
			return this.addBook;
		}
		public void addContact(ContactDetails contactObj)
		{
			addBook.AddLast(contactObj);
		}
		public LinkedList<ContactDetails> showContact()
		{
			return addBook;
		}
	}
}
