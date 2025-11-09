using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    internal class Human : Creature
    {
        public string Name;

        //Creature base; // created by compiler implicitly

        public Human() : base(10) // call parent constructor
        {                         // base علشان بنرث من كلاس واحد بدل مااكتب اسمه بكتب  base كتبنا 

        }
        //public override void Move()
        //{
        //    //base.Move();
        //    Console.WriteLine("Human is moving");
        //}

        //public override void Update()
        //{
        //}

         public new void Update() // not overriding but new method
        {
            Console.WriteLine("Human updating");
        }
           
        //public override void Eat()
        //{
        //    Console.WriteLine("Human is eating");
        //}
       
        public new virtual void Eat()
        {
            Console.WriteLine("Human is eating");
        }

        // Override Object.Equals method

        public override bool Equals(Object obj)
        {
            //Human h = (Human)obj; // this will throw InvalidCastException if obj is not Human

            // Using pattern matching (as)
            /*
            Human h = obj as Human; // this will assign null if obj is not Human
            if (h == null)
            {
                return false;
            }
            return this.Age == h.Age; 
            */

            // Using pattern matching (is) ❌
            /*
            if (obj is Human)
            {
                Human h = obj as Human;
                return this.Age == h.Age;
            }
            return false;
            */

            // Using pattern matching (is) ✔
            if (obj is Human h)
            {
                return this.Age == h.Age;
            }
            return false;
        }

        // Override Object.ToString method

        public override string ToString()
        {
            return $"Age {Age}";
        }

        public Human Clone()
        {
            return (Human) this.MemberwiseClone();
        }
    }
}
