using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    internal class Contact : IContact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Id { get; set; }
    }
}
