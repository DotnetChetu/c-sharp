using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSApp
{
    class MyList<T>
    {
        T[] arr;
        
        public MyList(int length)
        {
            arr = new T[length];
        }

        public void AddItem(int index, T item)
        {
            arr[index] = item;

        }

        public T GetItem(int index)
        {
            return arr[index];
        }

           
    }
}
