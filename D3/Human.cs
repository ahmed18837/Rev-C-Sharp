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
        public override void Move()
        {
            //base.Move();
            Console.WriteLine("Human is moving");
        }

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
    }
}
