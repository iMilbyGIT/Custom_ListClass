using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{

    public class CustomList<T> :IEnumerable
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
        public T this[int index] 
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
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
            }
            else if (count == capacity) //if we dont have space left in the array
            {
                capacity = capacity* 2;
                T[] tempRay = new T[capacity];

                for (int i = 0; i<count; i++)
                {
                    tempRay[i] = array[i];
                }
                    array = new T[capacity];
                for (int a = 0; a<count; a++)
                {
                    array[a] = tempRay[a];
                }
                array[count] = value;
            }
            count++;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }
}