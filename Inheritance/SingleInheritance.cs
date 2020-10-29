using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Organization  //Parent class or base class
    {
        //Protected: only child class can access the information of parent class
        protected string orgname = "LTI";
        protected string location;

        protected void DisplayOrg()
        {
            Console.WriteLine("OrgName:{0}||Location:{1}", orgname, location);
        }

    }

    //Inheritance
    class Employee : Organization//Employee child or derived class
    {
        int Eid = 1001;
        float salaryperhr = 900.78f;

        internal void DisplayEmployee()
        {
            //DisplayOrg();
            Console.WriteLine("Eid:{0}||salary:{1}||Orgname{2}", Eid, salaryperhr, orgname);
        }

        static void Main()
        {
            //Organization organization = new Organization();
            //organization.DispalyOrg();
            Employee employee = new Employee();
            //accessing parant  class information through child class obbject
            employee.location = "Chennai";
            employee.DisplayOrg();
            employee.DisplayEmployee();
            Console.Read();
        }

    }
    class SingleInheritance
    {
    }
}
