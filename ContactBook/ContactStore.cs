using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactBook
{
    internal class ContactStore : BaseContactStore, INotifiable
    {
        public ContactStore(IContactProvider contactProvider) : base(contactProvider)
        {
        }

        public event SaveDelegate SaveEvent;

        public override void Create(IContact contact)
        {
            contact.Id = _contacts.Count;

            foreach (var contactItem in _contacts)
            {
                if (contactItem.Name == contact.Name)
                {
                    throw new DeniedOperationException($"Contact with {nameof(contact.Name)} {contact.Name} is already exists");
                }
            }
            _contacts.Add(contact);
            SaveEvent.Invoke(_contacts);
        }

        public override IContact GetById(int id)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
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
                    return contacts;
                }
            }
            return contacts;
        }

        public override bool Remove(int id)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == id)
                {
                    _contacts.Remove(contact);
                    SaveEvent.Invoke(_contacts);
                    return true;
                }
                else throw new DeniedOperationException($"Contact with {nameof(contact.Id)} {id} is not exists");
            }
            return false;
        }

        public override void Update(IContact contact)
        {
            SaveEvent.Invoke(_contacts);
        }
    }
}
