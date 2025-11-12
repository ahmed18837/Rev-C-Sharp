using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    public class Employee : IComparable<Employee>
    {
        // Fields
        //  private int id;
        private decimal salary; // backfield for Salary property

       
        // Property for Salary
        //public decimal Salary
        //{
        //    get { return salary; }
        //    set
        //    {       
        //        if (value < 0) // value  --> Input parameter for the setter
        //        {
        //            throw new ArgumentOutOfRangeException("Salary cannot be negative.");
        //        }
        //        this.salary = value;
        //    }
        //}

        // Auto implemented property
        public int Id { get; set; }  // Compiler creates a backfield for this property (private int id);

        public Employee(int id)
        {
            this.Id = id;
        }
        public void setSalary(decimal value)
        {
            if (salary < 0)
            {
                throw new ArgumentOutOfRangeException("Salary cannot be negative.");
            }
            this.salary = value;
        }
        public decimal getSalary()
        {
            return this.salary;
        }

        public int CompareTo(Employee emp)
        {
            //    if (this.Id > emp.Id)
            //        return 1;
            //    if(this.Id < emp.Id) 
            //        return -1;
            
            //return 0;

            return this.Id.CompareTo(emp.Id);
        }
        //public int CompareTo(object? obj)
        //{
        //    if (obj is Employee emp)
        //    {
        //        if (this.Id > emp.Id)
        //            return 1;
        //        if(this.Id < emp.Id) 
        //            return -1;
        //    }
        //    return 0;
        //}
    }
}
