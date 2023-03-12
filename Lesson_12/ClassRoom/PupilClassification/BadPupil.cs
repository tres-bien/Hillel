using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class BadPupil : Pupil
    {
        public BadPupil()
        {
            success = "BAD";
            relax = "EXELENT";
        }

        public override void Study()
        {
            base.Study();
        }

        public override void Read()
        {
            base.Read();
        }

        public override void Write()
        {
            base.Write();
        }

        public override void Relax()
        {
            base.Relax();
        }
    }
}
