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

        public void Random(Pupil badPupil, Pupil goodPupil, Pupil exelentPupil)
        {
            
        }

        public void Study(string success)
        {
            Console.WriteLine($"Вчиться: {success}");
        }

        public void Read(string success)
        {
            Console.WriteLine($"Читає: {success}");
        }

        public void Write(string success)
        {
            Console.WriteLine($"Пише: {success}");
        }

        public void Relax(string relax)
        {
            Console.WriteLine($"Відпочиває: {relax}");
        }
    }
}
