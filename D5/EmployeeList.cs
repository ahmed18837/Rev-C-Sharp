using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    internal class EmployeeList : MyList<Employee>
    {
        public Employee this[string name]
        {
            get
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (this.GetByIndex(i).Name == name)
                        return this.GetByIndex(i);
                }
                return null;
            }
        }
    }
}
