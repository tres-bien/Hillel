using System;

namespace Classes
{
    class Author
    {
        private string _name;

        public string Name
        {
            get
            {
                if (_name != null)
                    return _name;

                return "Ім'я автора відсутнє.";
            }
            set
            {
                _name = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
