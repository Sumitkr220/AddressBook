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
		public string updateContact(ContactDetails contact1,ContactDetails contact2)
        {
			    int count = 0;
				if(contact2.firstName.Equals(contact1.firstName))
                {
					addBook.Remove(contact2);
					addBook.Add(contact1);
					count++;
                }
			if (count == 0)
			{
				return "no";
			}
			else
				return "yes";
        }
	}
}
