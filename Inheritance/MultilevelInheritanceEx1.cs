using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class AICTE
    {
      protected  void Standard()
        {
            Console.WriteLine("Standard");
        }
    }

    class MumbaiUniversity:AICTE
    {
        int UniversityNo = 10231;
        int TotalNumberOfSeats = 4561;
        internal void MStandards()
        {
            Standard();
            Console.WriteLine("Mumbai University, University No:{0},Total Number Of Seats:{1}", UniversityNo, TotalNumberOfSeats);
        }
    }

    class AnnaUniversity : AICTE
    {
        int UniversityNo = 48526;
        int TotalNumberOfSeats = 4829;
       internal void AStandards()
        {
            Standard();
            Console.WriteLine("Anna University, University No:{0},Total Number Of Seats:{1}", UniversityNo, TotalNumberOfSeats);
        }
    }
    class MultilevelInheritanceEx1
    {
        static void Main()
        {
            AnnaUniversity AU = new AnnaUniversity();
            MumbaiUniversity MU = new MumbaiUniversity();
            AU.AStandards();
            MU.MStandards();
            Console.Read();
        }

    }
}
