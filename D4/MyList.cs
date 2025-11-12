using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4
{
    public class MyList<T> where T : struct //where T : class
    {
        T[] items;
        int currntIndex;

        public MyList()
        {
            items = new T[5];
            currntIndex = -1;
        }
        public void Add(T item)
        {
            //if (item == null) where T : class
            if (currntIndex == items.Length - 1)
               throw new Exception();
            currntIndex++;
            items[currntIndex] = item;
        }

        public T GetByIndex(int ind) { return items[ind]; }
    }
}
