using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class ClassRoom
    {
        public Pupil[] pupils;

        Pupil pupil = new Pupil();

        public void Random(Pupil badPupil, Pupil goodPupil, Pupil exelentPupil)
        {
            Pupil[] arr = { badPupil, goodPupil, exelentPupil };

            for (int i = 0; i < pupils.Length; i++)
            {
                Random rand = new Random();
                int randomPupilSuccess = rand.Next(3);

                pupils[i] = arr[randomPupilSuccess];
            }
        }

        public void Show(Pupil badPupil, Pupil goodPupil, Pupil exelentPupil)
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"\n\tУчень №{i + 1}:\n");

                if (pupils[i] == badPupil)
                {
                    badPupil.Study(badPupil.success);
                    badPupil.Read(badPupil.success);
                    badPupil.Write(badPupil.success);
                    badPupil.Relax(badPupil.relax);
                }
                else if (pupils[i] == goodPupil)
                {
                    goodPupil.Study(goodPupil.success);
                    goodPupil.Read(goodPupil.success);
                    goodPupil.Write(goodPupil.success);
                    goodPupil.Relax(goodPupil.relax);
                }
                else if (pupils[i] == exelentPupil)
                {
                    exelentPupil.Study(exelentPupil.success);
                    exelentPupil.Read(exelentPupil.success);
                    exelentPupil.Write(exelentPupil.success);
                    exelentPupil.Relax(exelentPupil.relax);
                }
            }
        }
    }
}
