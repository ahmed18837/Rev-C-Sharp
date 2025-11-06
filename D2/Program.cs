using System;

namespace D2
{
    enum Gender
    {
        Male = 0,
        Female = 1,
    }

    [Flags]
    enum Weather : byte
    {
        Sunny = 1,
        Rainy = 2,
        Cloudy = 12,
        Snowy = 13
    }


    internal class Program
    {

        // ✅ تعريف كلاس Person (نوع مرجعي Reference Type)
        public class Person
        {
            public int ID;
            public Gender Type;

            public Person(int iD)
            {
                ID = iD;
            }

            public static bool operator ==(Person a, Person b)
            {
                return a.ID == b.ID;
            }

            public static bool operator !=(Person a, Person b)
            {
                return a.ID != b.ID;
            }
        }
        /*  
            // 1️⃣ الدالة test: تستقبل كائن (مرجع) وتعدل فيه
            static void test(Person p)
            {
                p.ID = 10; // تعديل في نفس الكائن اللي أُرسل من Main
            }

            // 2️⃣ الدالة test1 (بدون ref): تعيد تعيين المرجع داخل الدالة فقط
            static void test1(Person p)
            {
                p = new Person();  // هنا أنشأنا كائن جديد، لكن فقط داخل الدالة
                p.ID = 10;         // نعدل في الكائن الجديد (لن يؤثر على الكائن الأصلي)
            }

            // 3️⃣ الدالة test1 (مع ref): هنا نعدل المرجع نفسه (مش بس الكائن)
            static void test1(ref Person p)
            {
                p = new Person();  // هنا أنشأنا كائن جديد، والمرجع الأصلي في Main هيتغير يشير ليه
                p.ID = 10;         // نعدل في الكائن الجديد
            }

            // 4️⃣ الدالة test2 (مع ref): نعدل في الكائن الأصلي فقط بدون إنشاء جديد
            static void test2(ref Person p)
            {
                //p = new Person(); // السطر دا لو اتفعل هيخلي p يشير لكائن جديد
                p.ID = 10; // نعدل في نفس الكائن اللي في Main
            }

            // 5️⃣ test للأنواع القيمة (Value Type)
            static void test(int x)
            {
                x = 10; // تعديل على النسخة المحلية فقط، الأصل في Main مش هيتأثر
            }*/


        static void Main(string[] args)
        {
            // Reference Types vs Value Types in C#
            /*
            // ✅ الحالة الأولى
            Person p1 = new Person(); // إنشاء كائن جديد
            test(p1);                 // نمرر المرجع للدالة (by value)
            Console.WriteLine(p1.ID); // النتيجة = 10 لأننا عدلنا الكائن نفسه

            // ✅ الحالة الثانية
            Person p2 = new Person(); // كائن جديد
            p2.ID = 5;                // قيمة مبدئية
            test1(p2);                // أنشأنا كائن جديد داخل الدالة، لكن المرجع في Main ما اتغيرش
            Console.WriteLine(p2.ID); // النتيجة = 5 (ما اتأثرتش)

            // ✅ الحالة الثالثة
            Person p3 = new Person(); // كائن جديد
            p3.ID = 7;                // قيمة مبدئية
            test1(ref p3);            // ref معناها نمرر المرجع نفسه (مش نسخة منه)
            Console.WriteLine(p3.ID); // النتيجة = 10 (الكائن الجديد اللي اتعمل جوه الدالة)

            // ✅ الحالة الرابعة
            Person p4 = new Person(); // كائن جديد
            p4.ID = 7;                // قيمة مبدئية
            test2(ref p4);            // هنا ما أنشأناش كائن جديد، بس عدلنا الحقل ID
            Console.WriteLine(p4.ID); // النتيجة = 10

            // ✅ الحالة الخامسة
            int x = 5;                // نوع قياسي (Value Type)
            test(x);                  // نمرره بالنسخ (by value)
            Console.WriteLine(x);     // النتيجة = 5 (مش اتأثرت)

            p1.Type = Gender.Male;
            Console.WriteLine($"Person Type: {p1.Type}"); // Output: Person
            */

            // Enum
            /*
            Gender g = Gender.Female;
            Gender g2 = (Gender)1;
            Gender g3 = (Gender)15;

            Weather w1 = Weather.Sunny | Weather.Rainy; // Sum
            Console.WriteLine(w1);

            if ((w1 & Weather.Rainy) == Weather.Rainy) { // True
                                                         }
            */

            // Structs
            /*
            Complex c1; // لا تستخدم default constructor مع Structs
                             // يجب تهيئتها قبل الاستخدام
            
            c1.Real = 10;
            c1.Img = 20;
            Console.WriteLine($"Complex Number: {c1.Real} + {c1.Img}i");

            Complex c2 = new Complex(); // هنا استخدمنا default constructor
                                       // يستخدم القيمة الافتراضية
            Console.WriteLine($"Complex Number: {c2.Real} + {c2.Img}");

            Complex c3 = new Complex(3, 5); // استخدام constructor المخصص
            //c1 = c3;
            Console.WriteLine($"Complex Number: {c3.Real} + {c3.Img}");

            Complex c4 = c1 + c3; // استخدام operator overload // Complex c4 = Complex.operator +(c1, c3);

            Complex c5 = 7; // استخدام التحويل الضمني من int إلى Complex

            c1 = 5 + c3; // استخدام التحويل الضمني من int إلى Complex مع operator overload

            if (c1 == c3)  // استخدام operator overload للمقارنة
            {
                Console.WriteLine("c1 is equal to c3");
            }
            else
            {
                Console.WriteLine("c1 is not equal to c3");
            }

             // search ********
            Complex c6 = c1++; // استخدام operator overload للزيادة
            Complex c7 = ++c1; // استخدام operator overload للزيادة
            */

            // Class

            Person p1 = new Person(10);
            Person p2 = new Person(10);

            if (p1 == p2) // Comare By Ref

                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");

            Person p3 = p2;
            if (p3 == p2) // Comare By Ref

                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not Equal");


        }

    }
}