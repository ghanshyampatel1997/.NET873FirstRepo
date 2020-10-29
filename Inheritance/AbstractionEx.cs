using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class RBI
    {
        int empno = 20;
        public abstract int Homeloan();
        public abstract int Educationloan();

        //non Abstract method
        internal void RBIEmployee()
        {
            Console.WriteLine("RBI Employee details:{0}", empno);
        }
    }

    class SBI:RBI
    {
        
        public override int Homeloan()
        {
            return 9;
        }
        public override int Educationloan()
        {
            return 10;
        }
    }

    class HDFC : RBI
    {
        public override int Homeloan()
        {
            return 10;
        }
        public override int Educationloan()
        {
            return 11;
        }
    }

    class AbstractionEx
    {
        static void Main()
        {
            //can not create boject for abstract class
            //RBI r =new RBI();

            SBI sbi = new SBI();
            sbi.RBIEmployee();
            Console.WriteLine("SBI h loan:{0}", sbi.Homeloan());
            Console.WriteLine("SBI E loan:{0}", sbi.Educationloan());

            HDFC hdfc = new HDFC();
            Console.WriteLine("HDFC h loan:{0}", hdfc.Homeloan());
            Console.WriteLine("HDFC E loan:{0}", hdfc.Educationloan());

            //Run time polymorphism
            Console.WriteLine("----------------------------");
            Console.WriteLine("Run time polymorphism");

            //reference of RBI
            RBI r;
            //object for SBI
            r = new SBI();
            r.RBIEmployee();
            Console.WriteLine("SBI h loan:{0}", r.Homeloan());
            Console.WriteLine("SBI E loan:{0}", r.Educationloan());

            r = new HDFC();
            Console.WriteLine("HDFC h loan:{0}", r.Homeloan());
            Console.WriteLine("HDFC E loan:{0}", r.Educationloan());

            Console.Read();
        }
    }
}
