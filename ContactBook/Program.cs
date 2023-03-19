namespace ContactBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var provider = new InMemoryContactProvider();

            var contactStore = new ContactStore(provider);

            var contact = new Contact();
            contact.Name = "Denis";
            contact.PhoneNumber = "1234567890";

            var contact2 = new Contact();
            contact2.Name = "Vadim";
            contact2.PhoneNumber = "844838";

            var contact3 = new Contact();
            contact3.Name = "Cat";
            contact3.PhoneNumber = null;

            contactStore.Create(contact);
            contactStore.Create(contact2);
            contactStore.Create(contact3);
            contactStore.GetById(2);
            contactStore.GetByName("Va");
            contactStore.GetByPhoneNumber("84");
            contactStore.AllList();
            //contactStore.Update(contact);
            contactStore.Remove(2);
            contactStore.AllList();
        }
    }
}