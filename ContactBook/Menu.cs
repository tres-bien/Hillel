using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    enum EnumType : byte
    {
        Zero = 1,
        One,
        Two,
        Three,
        Four,
        Five,
        Six
    }

    internal class Menu
    {
        public void Run(ContactStore contactStore)
        {
            bool showMenu = true;

            while (showMenu)
            {
                showMenu = MainMenu(contactStore);
            }
        }

        private bool MainMenu(ContactStore contactStore)
        {
            EnumType enumType;
            int value;

            Console.Title = "### Contact Book ###";
            Console.Clear();
            Console.WriteLine("### Contact Book ###");
            Console.WriteLine(new string('_', 50));
            Console.Write("\nChose action:" +
                          "\n1 - Show contacts" +
                          "\n2 - Add contact" +
                          "\n3 - Update contact" +
                          "\n4 - Remove contact by Id" +
                          "\n5 - Search contact by phone number" +
                          "\n6 - Search contact by contact name" +
                          "\n7 - Exit" +
                          "\n\n\rSelect an option: ");

            int.TryParse(Console.ReadLine(), out value);

            enumType = (EnumType)value;

            try
            {
                switch (enumType)
                {
                    case EnumType.Zero:
                        Console.WriteLine();
                        return ShowContacts(contactStore);

                    case EnumType.One:
                        Console.WriteLine();
                        return AddContact(contactStore);

                    case EnumType.Two:
                        Console.WriteLine();
                        return UpdateContact(contactStore);

                    case EnumType.Three:
                        Console.WriteLine();
                        return RemoveContactById(contactStore);

                    case EnumType.Four:
                        Console.WriteLine();
                        return SearchByPhoneNumber(contactStore);

                    case EnumType.Five:
                        Console.WriteLine();
                        return SearchByName(contactStore);

                    case EnumType.Six:
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

        private bool UpdateContact(ContactStore contactStore)
        {
            Console.Write("Enter contact Id: ");
            var contact = contactStore.GetById(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Enter contact name: ");
            contact.Name = Console.ReadLine();

            Console.WriteLine($"Enter contact phone number: ");
            contact.PhoneNumber = Console.ReadLine();

            
            contactStore.Update(contact);
            return true;
        }

        private bool RemoveContactById(ContactStore contactStore)
        {
            Console.Write("Enter contact Id: ");
            contactStore.Remove(int.Parse(Console.ReadLine()));
            return true;
        }

        private bool SearchByPhoneNumber(ContactStore contactStore)
        {
            Console.WriteLine($"Enter contact phone number: ");
            foreach (var item in contactStore.GetByPhoneNumber(Console.ReadLine()))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            return true;
        }

        private bool SearchByName(ContactStore contactStore)
        {
            Console.WriteLine($"Enter contact name: ");
            foreach (var item in contactStore.GetByName(Console.ReadLine()))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            return true;
        }
    }
}
