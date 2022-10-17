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
            myArray.print();
            myArray.insert(50);
            myArray.removeAt(3);
            Console.WriteLine("Index of 10 is {0}", myArray.indexOf(10));
            Console.WriteLine("Index of 100 is {0}", myArray.indexOf(100));
            myArray.print();
            myArray.removeAt(8);
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
            print();
        }
        public void removeAt(int indexToDelete)
        {
            //validate the indexToDelete
            if (indexToDelete < 0 || indexToDelete >= count)
            {
                throw new ArgumentOutOfRangeException(String.Format("{0} is not a valid index", indexToDelete));
            }
            //shift items left to fill the hole
            //[10,20,30,40]
            //index: 1
            //1 <- 2
            //2 <-3
            var deletedNumber = internalArray[indexToDelete];
            for (var i = indexToDelete; i < count; i++)
            {               

                internalArray[i] = internalArray[i + 1];
            }
            count--; //decrement the count since we removed an entry
            Console.WriteLine("{0} was deleted from position {1}", deletedNumber, indexToDelete);
            return;
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

            for (var i = 0; i < count; i++)
            {
                //put item in new array
                bigInternalArray[i] = internalArray[i];
            }

            //replace old array with bigger array
            internalArray = bigInternalArray;
            Console.WriteLine("Array using {0} of {1} slots", count, internalArray.Length);

            Console.WriteLine("New array size is {0}", internalArray.Length);
        }
        public void print()
        {
            var sb = new System.Text.StringBuilder();
            for (var i = 0; i < count; i++)
            {
                sb.AppendFormat("..{0}", internalArray[i].ToString());
            }
            Console.WriteLine(sb.ToString());
        }

    }
}
