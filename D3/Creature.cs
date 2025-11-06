using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
     abstract class Creature
    {
        public int Age;
        protected int Height;
        protected int Weight;

        // Constructor chaining
        public Creature() : this(7)
        {

        }

        public Creature(int weight) : this(weight, 100)
        {
            this.Weight = weight;
        }
        public Creature(int weight, int height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        //public virtual void Move()
        //{
        //    Console.WriteLine("Creature is moving");
        //}

        public abstract void Move();

        public virtual void Update()
        {
            Console.WriteLine("Creature is updating");
        }
       
        public virtual void Eat()
        {
            Console.WriteLine("Creature is eating");
        }
    }
}
