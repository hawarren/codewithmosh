using System;

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
            myArray.insert(50);
            myArray.removeAt(3);
            Console.WriteLine("Index of 10 is {0}", myArray.indexOf(10));
            Console.WriteLine("Index of 100 is {0}", myArray.indexOf(100));
            myArray.print();


        }

    }
    class CustomArray
    {
        private int arraySize { get; set; }
        private int[] internalArray { get; set; }
        public int internalLength { get { return internalArray.Length; } }

        public CustomArray(int initialSize)
        {
            arraySize = 0;
            internalArray = new int[initialSize];
        }
        public void insert(int newItem)
        {
            var itemAdded = false;
            for (var i = 0; i < internalArray.Length; i++)
            {
                if (internalArray[i] == 0)//look for first empty position
                {
                    internalArray[i] = newItem;
                    itemAdded = true;
                    if (itemAdded)
                    {
                        arraySize++;
                        Console.WriteLine("{0} was added to the array", newItem);
                        resize();
                    }
                    return;
                }
            }

        }
        public int removeAt(int indexToDelete)
        {
            if (internalArray.Length - 1 > indexToDelete)
            {
                var tempNumber = internalArray[indexToDelete];
                internalArray[indexToDelete] = 0;
                arraySize--;
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
        public int resize()
        {
            if (arraySize * 2 >= internalArray.Length)
            {
                int[] bigInternalArray = new int[internalArray.Length * 2];
                var i = 0;
                var k = 0;
                var newArraysize = 0;
                while (newArraysize < arraySize && i  < internalLength)
                {

                    //skip if original array index is empty
                    if (internalArray[i] == 0)
                    {
                        i++;
                        continue;
                    }
                    //put item in new array
                    bigInternalArray[k] = internalArray[i];
                    //next position of original array
                    i++;
                    //next position of big array
                    k++;
                    //update size of big (new) array
                    newArraysize++;

                    if (internalArray.Length - 1 == i)
                    {
                        break;
                    }
                }

                internalArray = bigInternalArray;
                Console.WriteLine("Array using {0} of {1} slots", arraySize, internalArray.Length);
            }
            else if (arraySize * 4 >= internalArray.Length)
            {
                int[] smallInternalArray = new int[internalArray.Length];
                internalArray = smallInternalArray;
            }

            return arraySize;
        }
        public void print()
        {
            for (var i = 0; i < internalArray.Length; i++)
            {

                Console.WriteLine(internalArray[i]);
            }
        }

    }
}
