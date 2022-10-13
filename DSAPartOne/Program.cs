using System;

namespace DSAPartOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myArray = new CustomArray(5);
            myArray.insert(10);
            myArray.insert(20);
            myArray.insert(30);
            myArray.insert(40);
            myArray.removeAt(3);
            Console.WriteLine("Index of 10 is {0}",myArray.indexOf(10));
            Console.WriteLine("Index of 100 is {0}",myArray.indexOf(100));
            // foreach (var i = 0 in myArray){
            //     Console.WriteLine(item.ToString());
            // }
            // int[] numbers = new int[3];
            // int[] numbers = {10,20,30 };
            // numbers[0] = 10;
            // numbers[1] = 20;
            // numbers[2] = 30;
            // foreach (var item in numbers){

            // Console.WriteLine(item.ToString());
            // }
        }

    }
    class CustomArray
    {
        private int arraySize { get; set; }
        private int[] internalArray { get; set; }

        public CustomArray(int initialSize)
        {
            arraySize = initialSize;
            internalArray = new int[arraySize];
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
                        Console.WriteLine("{0} was added to the array", newItem);
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

    }
}
