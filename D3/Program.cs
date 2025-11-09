
using D3;
using System;
// Inheritance & Polymorphism
/*
Creature c1 = new Creature();
//c1.Move();

Human h1 = new Human();
//h1.Move();
h1.Update();

// Polymorphism
Creature c2 = new Human(); //  object from child class reversely assigned to parent class
//c2.Move();
c2.Update(); // calls parent class method not child class method

Employe e1 = new Employe();
Human h2 = new Employe();
Creature c3 = new Employe();

e1.Eat(); // هينفد ديما الاقرب لها فى سلسة الوراثة
c3.Eat();
h2.Eat();
*/

// any class inherits directly from object class

// Equals Function 
/*
Human obj1 = new Human();
Human obj2 = new Human();

obj1.Age = obj2.Age = 25;

if (obj1.Equals(100)) // Compare references by default
{
    Console.WriteLine("Equal");
}
else
{
    Console.WriteLine("Not Equal");
}

// Compare between
// public static bool Equals(Object? objA, Object? objB);
// public static bool ReferenceEquals(Object? objA, Object? objB); //  الغرض منها هو مقارنة العناوين في الذاكرة فقط (يعني هل الاتنين بيشاوروا على نفس الكائن؟
// أو تعديل سلوكها override لا يمكن 

// public virtual bool Equals(Object? obj); //الغرض منها هو مقارنة المحتوى (القيم) بين كائنين
// ليها في الكلاس بتاعك علشان تحدد إزاي المقارنة تتم override معناها إنك تقدر تعمل  "virtual" 
// Reference equality المقارنة بتكون  : override  لو ما عملتش 

Person p1 = new Person { Name = "Ahmed" };
Person p2 = new Person { Name = "Ahmed" };
Person p3 = p1;

Console.WriteLine("1️ Equals(instance):");
Console.WriteLine(p1.Equals(p2)); // ✅ True (بسبب override)
Console.WriteLine(p1.Equals(p3)); // ✅ True (نفس المرجع)
Console.WriteLine();

Console.WriteLine("2️ Object.ReferenceEquals:");
Console.WriteLine(Object.ReferenceEquals(p1, p2)); // ❌ False (مراجع مختلفة)
Console.WriteLine(Object.ReferenceEquals(p1, p3)); // ✅ True (نفس المرجع)
Console.WriteLine();

Console.WriteLine("3️ Object.Equals:");
Console.WriteLine(Object.Equals(p1, p2)); // ✅ True (استخدم override)
Console.WriteLine(Object.Equals(p1, null)); // ❌ False
Console.WriteLine(Object.Equals(null, null)); // ✅ True
*/

// ToString Function

Human h = new Human();
Human h1 = new Human();
h.Age = h1.Age = 20;

Console.WriteLine(h.ToString()); // describtion for object
Console.WriteLine(h);
Console.WriteLine(h.GetType()); // (runtime)  ترجع نوع الكائن في وقت التشغيل 
                                // System.Type  النوع اللي بترجعه من نوع 
int x = 10;
string s = "Ahmed";
Person p = new Person();

Console.WriteLine(x.GetType()); // System.Int32
Console.WriteLine(s.GetType()); // System.String
Console.WriteLine(p.GetType()); // Namespace.Person

// 👇 مثال إضافي لمعرفة اسم النوع فقط
Console.WriteLine(p.GetType().Name); // Person
Console.WriteLine(s.GetType().FullName); // System.String
object obj = "Hello";
Console.WriteLine(obj.GetType()); // System.String

//public class Animal { }
//public class Dog : Animal { }

//Animal a = new Dog();
//Console.WriteLine(a.GetType().Name); // Dog ✅ (النوع الفعلي في runtime)


h = h1;                         
Console.WriteLine(h.GetHashCode());
Console.WriteLine(h1.GetHashCode());
// (اسمها "Collision")  مش مضمونة 100%، ممكن قيمتين ترجع نفس  HashCode .
Human h2 = h.Clone();
Console.WriteLine(h2.Age);

Person p1 = new Person { Name = "Ahmed", Age = 25 };
Person p2 = new Person { Name = "Ahmed", Age = 25 };

Console.WriteLine(p1.Equals(p2));      // True
Console.WriteLine(p1.GetHashCode());   // نفس الرقم تقريبًا
Console.WriteLine(p2.GetHashCode());   // نفس الرقم
