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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
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
        public CustomList() : base()
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
                capacity *= 2;
                T[] tempRay = new T[capacity];

                    for (int i = 0; i<count; i++)
                    {
                        tempRay[i] = array[i];
                    }
                array = tempRay;
                array[count] = value;
            }
            count++;
        }
        public void Remove(T value)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }            
            if (index >= 0 && index < count)
            {
                RemoveAt(index);
            }
            else if (index != -1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index < count)
            {
                for (int i = index; i < count; i++)
                {
                    if (i != count - 1)
                    {
                        array[i] = array[i + 1];
                    }
                    else
                    {
                        array[i] = default;
                    }
                }
                count--;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public override string ToString()
        {         
                string stringVal = string.Empty;
                foreach (T value in this)
                {
                    if (string.IsNullOrEmpty(stringVal))
                    stringVal += value.ToString();
                    else
                    stringVal += string.Format(", {0}", value);
                }
                return stringVal; 
        }
        //public static CustomList operator -(CustomList l1)
        //{ }
    }
}