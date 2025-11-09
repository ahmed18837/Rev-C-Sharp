using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Override للمقارنة حسب القيمة
        public override bool Equals(object? obj)
        {
            if (obj is Person other)
                return this.Name == other.Name;
            return false;
        }
        // (consistency) علشان يفضل فيه تناسق منطقي   GetHashCode ل override لازم كمان تعمل Equals ل override لو عملت 
        public override int GetHashCode()
        {
            // لازم يكون متناسق مع Equals
            return HashCode.Combine(Name, Age);
        }
    }
}
