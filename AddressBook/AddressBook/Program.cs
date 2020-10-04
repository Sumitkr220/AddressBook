using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace AddressBook
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName, lastName, address, city, state, zipcode, phone, email;
			AddressBook addressBook = new AddressBook();
            int count;
            do
			{
				Console.WriteLine("Menu \nPress 1 to Add a contact \nPress 2 to Edit a Contact \nPress 3 to Remove a contact \nPress 4 to View all contact \nPress 5 to Exit");
				count = Convert.ToInt32(Console.ReadLine());
				switch (count)
				{
					case 1:
						Console.WriteLine("Welome to Address Book!!!");
						Console.WriteLine("Enter first name: ");
                        firstName = Console.ReadLine();
						Console.WriteLine("Enter last name: ");
						lastName = Console.ReadLine();
						Console.WriteLine("Enter address: ");
						address = Console.ReadLine();
						Console.WriteLine("Enter city: ");
						city = Console.ReadLine();
						Console.WriteLine("Enter state: ");
						state = Console.ReadLine();
						Console.WriteLine("Enter zip: ");
						zipcode = Console.ReadLine();
						Console.WriteLine("Enter phone number: ");
						phone = Console.ReadLine();
						Console.WriteLine("Enter email: ");
						email = Console.ReadLine();
						ContactDetails contact = new ContactDetails(firstName, lastName, address, city, state, zipcode, phone, email);
						addressBook.AddContact(firstName, contact);
						break;
					case 2:
						Console.WriteLine("Update contact: Enter name and all the details to update");
						Console.WriteLine("Enter first name: ");
						firstName = Console.ReadLine();
						Dictionary<string, ContactDetails> ContDet = new Dictionary<string, ContactDetails>();
						ContDet = addressBook.ShowContact();
						int flag = 0;
						foreach(KeyValuePair<string, ContactDetails> item in ContDet)
                        {
							if(item.Value.firstName.Equals(firstName))
                            {
								flag++;
                            }
                        }
						if (flag != 0)
						{
							Console.WriteLine("Enter last name: ");
							lastName = Console.ReadLine();
							Console.WriteLine("Enter address: ");
							address = Console.ReadLine();
							Console.WriteLine("Enter city: ");
							city = Console.ReadLine();
							Console.WriteLine("Enter state: ");
							state = Console.ReadLine();
							Console.WriteLine("Enter zip: ");
							zipcode = Console.ReadLine();
							Console.WriteLine("Enter phone number: ");
							phone = Console.ReadLine();
							Console.WriteLine("Enter email: ");
							email = Console.ReadLine();
							ContactDetails contact1 = new ContactDetails(firstName, lastName, address, city, state, zipcode, phone, email);
							string check = addressBook.updateContact(firstName, contact1);
							if (check.Equals("yes"))
							{
								Console.WriteLine("Update Successfully");
							}
						}
						else
                        {
							Console.WriteLine("No name there to update");
                        }
						break;
					case 3:
                        Console.WriteLine("Enter first name of contact to remove:");
					    string fname=Console.ReadLine();
						bool b = addressBook.RemoveContact(fname);
						if (b)
							Console.WriteLine("Contact removed");
			         	else
							Console.WriteLine("Contact not found");
						break;
					case 4:
						Dictionary<string, ContactDetails> contDet = new Dictionary<string, ContactDetails>();
						contDet = addressBook.ShowContact();
						foreach (KeyValuePair<string, ContactDetails> item in contDet)
						{
							Console.WriteLine(item.Value.toString());
						}
						break;
					case 5: break;
				}
			} while (count != 5);
		}
	}
}
	


