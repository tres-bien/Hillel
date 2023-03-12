using System.Text;

namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            var classRoom = new ClassRoom();

            classRoom.pupils = new Pupil[4];

            Pupil badPupil = new BadPupil();
            Pupil goodPupil = new GoodPupil();
            Pupil exelentPupil = new ExelentPupil();

            classRoom.Random(badPupil, goodPupil, exelentPupil);

            classRoom.Show(badPupil, goodPupil, exelentPupil);
        }
    }
}