using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Collage1
    {
        protected string id = "C101";
        // protected string collagename = "MIT";
        protected string Collegename;
        internal Collage1(string Collagename)
        {
            this.Collegename = Collagename;
            Console.WriteLine("Collage constructor");

        }
        ~Collage1()
        {
            Console.WriteLine("collage Destructor");

        }
    }

    class Department1 : Collage1
    {
        protected string id = "d1000";
        //protected string deptname = "CSE";
        protected string Deptname;
        internal Department1(string cname, string Deptname) : base(cname)
        {
            this.Deptname = Deptname;
            Console.WriteLine("Department constructor");
        }
        protected void GetDept()
        {
            Console.WriteLine("Collageid:{0}||DeptId:{1}", base.id, id);
            Console.WriteLine("Collage name:{0}||Department name:{1}", Collegename, Deptname);
        }
        ~Department1()
        {
            Console.WriteLine("Department Destructor");
        }
    }

    class Student1 : Department1
    {
        //string Sname = "Mani";
        string stuname;
        Student1(string cname,string dname,string stuname):base(cname,dname)
        {
            this.stuname = stuname;
            Console.WriteLine("Student constructor");
        }
        void DisplayStuInfo()
        {
            Console.WriteLine("Collage name:{0}||Department name:{1}||Student name:{2}", Collegename, Deptname, stuname);

        }

        static void Main()
        {
            Student1 student1 = new Student1("MIT","M.Tech","jay");
            student1.GetDept();
            student1.DisplayStuInfo();
            GC.Collect();
            Console.Read();
        }
        ~Student1()
        {
            Console.WriteLine("Student destructor");
        }
    
    }
    class MultilevelInheritanceEx2
    {
    }
}
