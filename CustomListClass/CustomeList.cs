﻿using System;
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
        private readonly T[] array;
        
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
            else
            {
                capacity *= 2; //if we don't have space left in the array, trash old and create new with double the capacity
                T[] tempArray = new T[capacity];
                tempArray + 


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
