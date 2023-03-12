using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class Pupil
    {
        public string success;
        public string relax;

        public virtual void Study()
        {
            Console.WriteLine($"Вчиться: {success}");
        }

        public virtual void Read()
        {
            Console.WriteLine($"Читає: {success}");
        }

        public virtual void Write()
        {
            Console.WriteLine($"Пише: {success}");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"Відпочиває: {relax}");
        }
    }
}
