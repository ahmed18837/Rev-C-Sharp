using D5;
using System.Collections;
// IEnumerable
/*
MyList myList = new MyList();
myList.Add(5);
myList.Add(6);
myList.Add(7);
myList.Add(8);
myList.Add(9); 

//for  (int i = 0; i < myList.Count; i++)
//    Console.WriteLine(myList.GetByIndex(i));

int[] arr = [1, 2, 3, 4, 5];
// foreach (var item in arr) // Array فى  ForLoop بتتحول الى  Foreach 
// Console.WriteLine(item);

IEnumerator enumerator = arr.GetEnumerator(); 
while (enumerator.MoveNext()) // List , Dectionary فى  while بتتحول الى  Foreach 
{
    int x = (int)enumerator.Current;  
    Console.WriteLine(x);             
}
Console.WriteLine("************");
foreach (var item in arr)
    Console.WriteLine(item);

foreach (var item in myList)
    Console.WriteLine(item);
*/

// Object Initializer
Employee emp = new Employee(10) { Name = "Ali", Salary = 1000};
Employee emp1 = new Employee { Name = "Ali", Salary = 1000};

//MyList<int> myList = new MyList<int>();
//myList.Add(5);
//myList.Add(6);
//myList.Add(7);
//myList.Add(8);
//myList.Add(9);

EmployeeList employeeList = new EmployeeList();

Employee employee = employeeList["Ali"];

List<int> list = new List<int>();
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);

LinkedList<int> linkedList = new LinkedList<int>(); // List لو بحدف او اضيف يبقى افضل من 
SortedList<int, string> sortedList = new SortedList<int, string>(); 
sortedList.Add(1, "One");

HashSet<string> hashSet = new HashSet<string>();
hashSet.Add("Ali");
hashSet.Add("Ahmed");

Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "One");
if (dictionary.ContainsKey(1))
{
    string value = dictionary[1];
    Console.WriteLine(value);
}

foreach (KeyValuePair<int, string> item in dictionary)
{
    Console.WriteLine($"Key = {item.Key} \t Value = {item.Value}");
} 
