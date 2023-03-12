using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class ClassRoom
    {
        public ClassRoom(Pupil[] pupils, Pupil[] arr)
        {
            this.pupils = pupils;
            Random(arr);
        }
        private void Random(Pupil[] arr)
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Random rand = new Random();
                int randomPupilSuccess = rand.Next(3);

                pupils[i] = arr[randomPupilSuccess];
            }
        }

        public Pupil[] pupils;

        Pupil pupil = new Pupil();

        public void Show(Pupil badPupil, Pupil goodPupil, Pupil exelentPupil)
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"\n\tУчень №{i + 1}:\n");

                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }
}
