using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);

            //int[] one = new int[4];
            //one[0] = 2;
            //one[1] = 4;
            //one[2] = 6;
            //one[3] = 8;

            //int[] two = new int[8];
            //two[4] = 10;

            CustomList<int> myNumbers = new CustomListClass<int>();


        }
    }
}
