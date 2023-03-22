namespace ContactBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var provider = new InMemoryContactProvider();
                var contactStore = new ContactStore(provider);
                var menu = new Menu();

                menu.Run(contactStore);

                throw new DeniedOperationException("Plese retry");
            }
            catch (DeniedOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception)
            {
                Console.WriteLine($"Ooops... something went wrong");
            }
        }
    }
}