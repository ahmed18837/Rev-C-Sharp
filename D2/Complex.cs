using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    public struct Complex
    {   // Class or Struct default member is private
        // Class reference type , Struct value type
        // Class can Inherit more class, Struct Cannot Inherit from another class or struct
        public int Real;
        public int Img;
        // default constructor
        //public  Complex ()
        //     {
        //     Real = default; 
        //     Img = default;
        //  

        public Complex(int Real, int Img)
        {
            this.Real = Real;
            this.Img = Img;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Img + c2.Img);
        }

        public static implicit operator Complex(int num)
        {
            return new Complex(num, 0);
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return (c1.Real == c2.Real) && (c1.Img == c2.Img);
        }
        // Must override Equals and GetHashCode when overloading == and !=
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        public static Complex operator ++(Complex c1)
        {
            return new Complex(c1.Real + 1, c1.Img + 1);
        }


    }
}
