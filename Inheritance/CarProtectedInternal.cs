using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class CarProtectedInternal:Parts
    {
        static void Main()
        {
            CarProtectedInternal c = new CarProtectedInternal();

            c.wheel = 4;
            c.motor = "4 piston";
                c.DispalyParts();
            Console.Read();
        }
    }
}
