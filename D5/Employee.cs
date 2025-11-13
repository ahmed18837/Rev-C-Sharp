using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }

        public Employee()
        {
            
        }
        public Employee(int id)
        {
            this.Id = id;
        }


    }
}
