
using D3;

Creature c1 = new Creature();
//c1.Move();

Human h1 = new Human();
h1.Move();
h1.Update();

// Polymorphism
Creature c2 = new Human(); //  object from child class reversely assigned to parent class
c2.Move();
c2.Update(); // calls parent class method not child class method

Employe e1 = new Employe();
Human h2 = new Employe();
Creature c3 = new Employe();

e1.Eat(); // هينفد ديما الاقرب لها فى سلسة الوراثة
c3.Eat();
h2.Eat();