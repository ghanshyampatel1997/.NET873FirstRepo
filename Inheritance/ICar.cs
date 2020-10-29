using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /*Create an Interface called ICar which contains the following methods break(),Engine(). 
Create a car company called Benz which implements ICar interface and it  also has the method called BenzFunctionality()
, Toyota implements ICar interface and it also has the method called ToyotaFunctionality()
     */
    interface ICar
    {
        void Break();
        void Engine();
        //string Steering();
    }

    class Benz : ICar
    {
        public void Break()
        {
            Console.WriteLine("Benz has best breaks");
        }

        public void Engine()
        {
            Console.WriteLine("Benz has Fast Engine");

        }

        internal void BenzFunctionality()
        {
            Console.WriteLine("The comfort, the premium upholstery, the plush carpeting, sleek styling, LED mood lighting");
        }
    }

    class Toyota : ICar
    {
        public void Break()
        {
            Console.WriteLine("Toyota has Faster breaks system");
        }

        public void Engine()
        {
            Console.WriteLine("Toyota has Smooth Engine");
        }

        internal void ToyotaFunctionality()
        {
            Console.WriteLine("space, fuel efficiency, and horsepower to satisfy any family");
        }
    }

    class Maruti : ICar
    {
        void ICar.Break()
        {
            Console.WriteLine("Maruti has  best breaks");
        }

        public void Engine()    ///mention public if dint want to mention interferance class name befor method name
        {
            Console.WriteLine("Maruti has  Fast Engine");

        }
    }

    class Carall
    {
        static void Main()
        {
            ICar car = new Benz();
            car.Break();
            car.Engine();
            

            car = new Toyota();
            car.Break();
            car.Engine();

            car = new Maruti();
            car.Break();
            car.Engine();

            Benz Bcar = new Benz();
            Bcar.BenzFunctionality();

            Toyota Tcar = new Toyota();
            Tcar.ToyotaFunctionality();

            Console.Read();
        }
    }


}
