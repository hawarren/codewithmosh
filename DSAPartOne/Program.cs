using System;
using System.Collections.Generic;

namespace DSAPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myArray = new CustomArray(1);
            myArray.insert(10);
            myArray.insert(20);
            myArray.insert(30);
            myArray.insert(40);
            //myArray.insert(50);
            //myArray.removeAt(3);
            Console.WriteLine("Index of 10 is {0}", myArray.indexOf(10));
            Console.WriteLine("Index of 100 is {0}", myArray.indexOf(100));
            myArray.print();


        }

    }
    class CustomArray
    {
        private int count { get; set; }
        private int[] internalArray { get; set; }
        public int internalLength { get { return internalArray.Length; } }

        public CustomArray(int initialSize)
        {
            count = 0;
            internalArray = new int[initialSize];
        }
        public void insert(int newItem)
        {            
            if (internalArray.Length == count)
            {
                resize();
            }
            internalArray[count++] = newItem; //add item to array at last position, then increment count
            Console.WriteLine("{0} was added to the array", newItem);            
        }
        public int removeAt(int indexToDelete)
        {
            if (internalArray.Length - 1 > indexToDelete)
            {
                var tempNumber = internalArray[indexToDelete];
                internalArray[indexToDelete] = 0;
                count--;
                Console.WriteLine("{0} was deleted from position {1}", tempNumber, indexToDelete);
                return tempNumber;
            }
            else
            {
                Console.WriteLine("Please choose value within index range");
                return -1;
            }
        }
        public int indexOf(int numToCheck)
        {
            for (var i = 0; i < internalArray.Length; i++)
            {
                if (numToCheck == internalArray[i])
                {
                    var thisIndex = i;
                    return i;
                }
            }
            return -1;
        }
        void resize()
        {
            int[] bigInternalArray = new int[internalArray.Length * 2];
                       
            for (var i = 0; i < count; i++ )
            {
                //put item in new array
                bigInternalArray[i] = internalArray[i];
               
                //update size of big (new) array
                internalArray = bigInternalArray;
                Console.WriteLine("Array using {0} of {1} slots", count, internalArray.Length);
            }           
        }
        public void print()
        {
            List<int> arrayList = new List<int>();
            for (var i = 0; i < internalArray.Length; i++)
            {
                arrayList.Add(internalArray[i]);
                Console.WriteLine(internalArray[i]);
            }
            Console.WriteLine(arrayList.ToString());
        }

    }
}
