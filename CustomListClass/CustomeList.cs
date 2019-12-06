using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{

    public class CustomList<T> where T : new()
    {
        private int count;
        private int capacity;
        private T[] array;
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T[] Array
        {
            get
            {
                return array;
            }
        }
        public CustomList()
        {
            count = 0;
            capacity = 4;
            array = new T[capacity];
        }
        public void Add(T value)
        {
            if (count != capacity) //if we have space left in the array 
            {
                array[count] = value;
                count++;
            }
            else
            {
                capacity *= 2;
                T[] temp = new T[capacity];
            }
        }
    }
}
