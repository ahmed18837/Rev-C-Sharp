using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5
{
    public class MyList<T> : IEnumerable
    { 
        protected T[] items;
        int currntIndex;

        public int Count { get { return currntIndex + 1;  } }
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

        public T GetByIndex(int index) { return items[index]; }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator : IEnumerator
        {
            MyList<T> myList;
            int index;
            public Iterator(MyList<T> myList)
            {
                this.myList = myList;
                index = -1;
            }

            public object Current
            {
                get
                {
                    return myList.items[index]; 
                }
            }
            public bool MoveNext()
            {
                index++;
                return index <= myList.currntIndex;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }           
        }

        // Indexer
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
    }
}
