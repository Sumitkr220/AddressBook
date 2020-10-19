using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class ContactDetails
    {
		public string firstName;
		public string lastName;
		public string address;
		public string city;
		public string state;
		public string zipcode;
		public string phone;
		public string email;
		public ContactDetails(string firstName, string lastName, string address, string city, string state, string zipcode, string phone, string email)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.address = address;
			this.city = city;
			this.state = state;
			this.zipcode = zipcode;
			this.phone = phone;
			this.email = email;
		}
    	public String toString()
		{
			return "First Name: " + firstName + "\nLast Name: " + lastName + "\nAddress: " + address + "\nCity: " + city + "\nState: " + state + "\nZip: " + zipcode + "\nPhone Number: " + phone + "\nEmail: " + email;
		}
	}
}
