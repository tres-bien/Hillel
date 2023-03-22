using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactBook
{
    internal class ContactStore : BaseContactStore
    {
        public ContactStore(IContactProvider contactProvider) : base(contactProvider)
        {
        }

        public override void Create(IContact contact)
        {
            contact.Id = _contacts.Count;
            try
            {
                if (_contacts.Count>0)
                {
                    foreach (var contactItem in _contacts)
                    {
                        if (contactItem.Name.Contains(contact.Name))
                        {
                            throw new DataMisalignedException($"Contact with {nameof(contact.Name)} {contact.Name} is already exists");
                        }
                    }
                }
                else _contacts.Add(contact);
            }
            catch (DeniedOperationException exeption)
            {
                Console.WriteLine($"Contact with {nameof(contact.Name)} {contact.Name} is already exists");
            }
        }

        public override IContact GetById(int id)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
                    Console.WriteLine(contact.Name);
                    return contact;
                }
            }
            return null;
        }

        public override IEnumerable<IContact> GetByName(string name)
        {
            List<IContact> contacts = new List<IContact>();
            foreach (var contact in _contacts)
            {
                if (contact.Name.Contains(name))
                {
                    Console.WriteLine(contact.PhoneNumber);
                    contacts.Add(contact);
                    return contacts;
                }
            }
            return contacts;
        }

        public override IEnumerable<IContact> GetByPhoneNumber(string phoneNumber)
        {
            List<IContact> contacts = new List<IContact>();
            foreach (var contact in _contacts)
            {
                if (contact.PhoneNumber.Contains(phoneNumber))
                {
                    Console.WriteLine(contact.PhoneNumber);
                    contacts.Add(contact);
                    return contacts.ToArray();
                }
            }
            return contacts.ToArray();
        }

        public override bool Remove(int id)
        {
            foreach(var contact in _contacts)
            {
                try
                {
                    if (contact.Id == id)
                    {
                        _contacts.Remove(contact);
                        return true;
                    }
                    else throw new DataMisalignedException($"Contact with {nameof(contact.Id)} {id} is not exists");
                }
                catch (DataMisalignedException exeption)
                {
                    throw exeption;
                }
                
            }
            return false;
        }

        public override void Update(IContact contact)
        {
            contact.Name = Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
        }

        public void AllList()
        {
            foreach (var contact in _contacts)
            {
                Console.WriteLine("Name: {0} Phone: {1} Id: {2}", contact.Name, contact.PhoneNumber, contact.Id);
            }
        }
    }
}
