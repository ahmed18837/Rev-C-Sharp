
using D4;

Employee e1 = new Employee(10);

//e1.Salary = 400; //e1.setSalary(400);
//decimal x = e1.Salary; //decimal x = e1.getSalary();

// Generic Method to swap two values
static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}

int a = 5;
int b = 6;
 
Swap(ref a, ref b); // Swap<int>(ref a, ref b);

MyList<int> l1 = new MyList<int>();
l1.Add(5);
l1.Add(6);

// Generaztion ??
// IComparable & IComparer ?? 

IMovable m1 = new Car();
m1.Move();

ITestable t1 = new Car();
t1.Move();

Car c1 =  new Car();
//c1.Move(); // Not allowed because Move is explicitly implemented

Employee[] employees = new Employee[3];
employees[0] = new Employee(5);
employees[1] = new Employee(10);
employees[2] = new Employee(13);

Array.Sort(employees);

for (int i = 0; i < employees.Length; i++)
    Console.WriteLine(employees[i].Id);