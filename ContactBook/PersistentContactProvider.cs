using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ContactBook
{
    internal class PersistentContactProvider : IContactProvider, IContactSaveable
    {
        public bool Save(IEnumerable<IContact> items)
        {
            var fileName = new FileInfo(@"ContactBook.txt");

            FileStream file = fileName.Create();

            StreamWriter writer = new StreamWriter(file, Encoding.Unicode);

            foreach (var item in items)
            {
                writer.WriteLine($"{item.Id},{item.Name},{item.PhoneNumber};");
            }

            writer.Close();

            return fileName.Exists;
        }

        public IEnumerable<IContact> Get()
        {
            List<IContact> contacts = new List<IContact>();

            var directory = new DirectoryInfo(".");

            if (directory.Exists)
            {
                FileInfo[] files = directory.GetFiles("*.txt");

                foreach (FileInfo file in files)
                {
                    if (file.Name == "ContactBook.txt")
                    {
                        string path = file.FullName;
                        using (StreamReader reader = new StreamReader("ContactBook.txt"))
                        {
                            string text = File.ReadAllText(path);
                            text = text.Trim('\n', '\r');
                            string[] contactArray = null;

                            string[] contactsArray = text.Split(new char[] { ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < contactsArray.Length; i++)
                            {
                                contactArray = contactsArray[i].Split(',', StringSplitOptions.RemoveEmptyEntries);
                                contacts.Add(new Contact() { Id = int.Parse(contactArray[0]), Name = contactArray[1], PhoneNumber = contactArray[2] });
                            }
                        }
                    }
                }
            }

            return contacts;
        }
    }
}
