using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    internal class Car : IMovable, ITestable
    {
        // Implicit implementation
        //public void Move()
        //{
        //    Console.WriteLine("Car Moving ...");
        //}

        // Explicit implementation
        void IMovable.Move()
        {
            Console.WriteLine("Car Moving ...");
        }

        void ITestable.Move()
        {
            Console.WriteLine("Car Testing ...");
        }

        //public void Move()
        //{
        //    Console.WriteLine("Car Public Move ...");
        //}
    }
}
