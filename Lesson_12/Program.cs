using System.Text;

namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Pupil badPupil = new BadPupil();
            Pupil goodPupil = new GoodPupil();
            Pupil exelentPupil = new ExelentPupil();

            Pupil[] arr = { badPupil, goodPupil, exelentPupil };

            var classRoom = new ClassRoom(new Pupil[4], arr);

            classRoom.Show(badPupil, goodPupil, exelentPupil);
        }
    }
}