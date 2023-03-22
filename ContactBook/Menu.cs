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
                Console.Write("\nChose action:\n1 - Add contact\n2 - Exit\n\n\rSelect an option: ");
            }
            else
            {
                Console.Write("\nChose action:\n1 - Show contacts\n2 - Add contact\n3 - Remove contact by Id\n4 - Exit\n\n\rSelect an option: ");
            }
            switch (Console.ReadLine())
            {
                case "1" when counter != 0:
                    foreach (var contacts in contactStore)
                    {
                        Console.WriteLine(contacts);
                    }
                    Console.ReadLine();
                    return true;

                case "2" when counter != 0:
                case "1" when counter == 0:
                    Console.WriteLine($"Enter contact name and phone number: ");
                    contactStore.Create(new Contact
                    {
                        Name = Console.ReadLine(),
                        PhoneNumber = Console.ReadLine()
                    });
                    return true;

                case "3" when counter != 0:
                    Console.Write("Enter contact Id: ");
                    contactStore.Remove(int.Parse(Console.ReadLine()));
                    return true;

                case "4" when counter != 0:
                case "2" when counter == 0:
                    return false;

                default:
                    return false;
            }
        }
    }
}
