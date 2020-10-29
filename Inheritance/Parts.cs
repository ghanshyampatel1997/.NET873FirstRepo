using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parts
    {
        protected internal int wheel;
        protected internal string motor;
        protected internal void DispalyParts()
        {
            Console.WriteLine("Wheel:{0}:||Motor:{1}", wheel, motor);
        }
    }
}
