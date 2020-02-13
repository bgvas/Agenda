using System;

namespace Agenda
{
    class Program
    {
        public static void Main(string[] args)
        {

            int selection = 5;
            int code;
            string fname, lname, phone;
           
            ContactsCatalog Catalog = new ContactsCatalog();
            while (true)
            {
                Console.Write("\n\tMy Agenda\n\n");
                Console.WriteLine("1. Add a new Contact");
                Console.WriteLine("2. View an existing Contact");
                Console.WriteLine("3. Edit a Contact");
                Console.WriteLine("4. List with all Contacts");
                Console.WriteLine("0. EXIT");

                do
                {
                    Console.Write("Select: ");
                    try
                    {
                        selection = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.FormatException){ } // Don't print nothing on error selection
                } while (selection < 0 || selection > 4);


                switch (selection)
                {
                    case 0:
                        break;
                    case 1:
                        do
                        {
                            Console.Write("Type first name:");
                            fname = Console.ReadLine();
                            Console.Write("Type last name:");
                            lname = Console.ReadLine();
                            Console.Write("Type mobile phone:");
                            phone = Console.ReadLine();
                        } while (fname.Equals("") || lname.Equals("") || phone.Equals(""));
                        Catalog.SetNewContact(fname, lname, phone);
                        break;
                    case 2:
                        do
                        {
                            Console.Write("Type the code to view the contact:");
                            code = Convert.ToInt32(Console.ReadLine());
                        } while (code < 0 || code > Catalog.GetAllContacts().Count + 1);
                        try
                        {
                            Console.WriteLine();
                            Catalog.GetASpecificContact(code).PrintContact();
                        }
                        catch (System.NullReferenceException)
                        {
                            Console.WriteLine("Contact, does not exist!!!");
                        }
                        
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.WriteLine();
                        foreach (Contact c in Catalog.GetAllContacts())
                        {
                            c.PrintContact();
                        }
                        break;
                }
                if(selection == 0)
                {
                    break;
                }
            }
        }
    }
}
