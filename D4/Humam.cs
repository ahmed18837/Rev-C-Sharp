using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    internal class Humam : Creature, IMovable
    {
        public override void Move()
        {
            Console.WriteLine("Human Move ...");
        }
    }
}
