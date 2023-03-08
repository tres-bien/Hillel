using System;

namespace Classes
{
    class Title
    {
        private string _content;

        public string Content
        {
            get 
            {
                if (_content != null)
                    return _content;

                return "Заголовок відсутній.";
            }
            set 
            {
                _content = value; 
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
