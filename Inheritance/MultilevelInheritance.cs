using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class collage
    {

        protected string collagename = "MIT";
    }

    class Department : collage
    {
        protected string deptname = "CSE";
        protected void GetDept()
        {
            Console.WriteLine("Collage name:{0}||Department name:{1}", collagename, deptname);
        }
    }

    class Student : Department
    {
        string Sname = "Mani";

        void DisplayStuInfo()
        {
            Console.WriteLine("Collage name:{0}||Department name:{1}||Student name:{2}", collagename, deptname,Sname);

        }

        static void Main()
        {
            Student student = new Student();
            student.GetDept();
            student.DisplayStuInfo();
            Console.Read();
        }
    }
    class MultilevelInheritance
    {
    }
}
