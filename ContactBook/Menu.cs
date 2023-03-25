using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    internal class Menu
    {
        public void Run(ContactStore contactStore)
        {
            bool showMenu = true;
            int counter = 0;

            while (showMenu)
            {
                showMenu = MainMenu(contactStore, counter);
                counter++;
            }
        }

        private bool MainMenu(ContactStore contactStore, int counter)
        {
            Console.Title = "### Contact Book ###";
            Console.Clear();
            Console.WriteLine("### Contact Book ###");
            Console.WriteLine(new string('_', 50));

            if (counter == 0)
            {
                Console.Write("\nChose action:\n1 - Show contacts\n2 - Add contact\n3 - Exit\n\n\rSelect an option: ");
            }
            else
            {
                Console.Write("\nChose action:\n1 - Show contacts\n2 - Add contact\n3 - Remove contact by Id\n4 - Exit\n\n\rSelect an option: ");
            }

            try
            {
                switch (Console.ReadLine())
                {
                    case "1":

                        return ShowContacts(contactStore);

                    case "2":

                        return AddContact(contactStore);

                    case "3" when counter != 0:

                        return RemoveContactById(contactStore);

                    case "4" when counter != 0:
                    case "3" when counter == 0:
                        return false;

                    default:
                        return false;
                }
            }
            catch (DeniedOperationException exeption)
            {
                Console.WriteLine(exeption.Message);
            }
            catch (Exception)
            {
                Console.WriteLine($"Ooops... something went wrong");
            }
            return false;
        }

        private bool AddContact(ContactStore contactStore)
        {
            var contact = new Contact();

            Console.WriteLine($"Enter contact name: ");
            contact.Name = Console.ReadLine();

            Console.WriteLine($"Enter contact phone number: ");
            contact.PhoneNumber = Console.ReadLine();

            contactStore.Create(contact);
            return true;
        }

        private bool ShowContacts(ContactStore contactStore)
        {
            foreach (var contacts in contactStore)
            {
                Console.WriteLine(contacts);
            }
            Console.ReadKey();
            return true;
        }

        private bool RemoveContactById(ContactStore contactStore)
        {
            Console.Write("Enter contact Id: ");
            contactStore.Remove(int.Parse(Console.ReadLine()));
            return true;
        }
    }
}
