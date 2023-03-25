namespace ContactBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persisrent = new PersistentContactProvider();
            persisrent.Get();

            var provider = new InMemoryContactProvider();
            var contactStore = new ContactStore(persisrent);
            var menu = new Menu();

            menu.Run(contactStore);

            persisrent.Save(contactStore);
        }
    }
}