using System;


namespace DataStructureAndAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            DSArray numbers = new DSArray(3);
            //numbers.Insert(5);
            //numbers.Insert(10);
            //numbers.Insert(15);
            //numbers.Insert(20);
            //numbers.RemoveAt(3);
            //Console.WriteLine(string.Format("Found at {0}", numbers.IndexOf(15)));
            //numbers.Print();

            int[] arrayNumbers = { 10, 15, 20,50, 25, 30, 35 };

            //Console.WriteLine(numbers.FindMax(arrayNumbers));
            numbers.ArrayReverse(arrayNumbers);
         //   numbers.rvereseArray(arrayNumbers, 0, 5);
            //Extent New Array Length
            int[] newArrayNumbers = new int[arrayNumbers.Length + 1];
            ////Item to Add
            //int AddNewElement = 25;
            ////Adding Item end of the arrary
            //newArrayNumbers[3] = AddNewElement;
            ////Binding older to to new array
            //for (int i = 0; i < arrayNumbers.Length; i++)
            //{
            //    newArrayNumbers[i] = arrayNumbers[i];

            //}
            ////Assigning new array to older array


            //for (int i = 0; i < newArrayNumbers.Length; i++)
            //{
            //    Console.WriteLine(newArrayNumbers[i]);
            //}
            //Console.ReadKey();
        }
    }

    public class DSArray
    {
        private int[] items;
        private int count;

        //Dynamic Array Creation
        public DSArray(int length)
        {
            items = new int[length];
        }


        public  void Insert(int item)
        {
            //Increase current array size
            //Check if the array length and count is same
            //Make new array of double length of older
            //loop over the current array and assign value into new array
            //Assign new array into exsisting array 
            //Return the older array
            items[count++] = item;

            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];
                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                items = newItems;
            }
        }
        //Swaping algorithm
        //temp
        //start
        //end
        //temp = start
        //start = end 
        //end = temp
        public void rvereseArray(int[] arr, int start, int end)
        {
            int temp;

            while (start < end)
            {

                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        public void RemoveAt(int index)
        {
            //Validate Input
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Invalid Operation");
                throw new IndexOutOfRangeException();

            }
            //Resize array Element  
            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            //Remove empty item from array
            count--;

        }

        public int IndexOf(int item)
        {
            // Runtime complexity
            // Best Case O(1) if found at the begining
            // Worst Case O(n) if found at the end

            for (int i = 0; i < count; i++)
                if (items[i] == item)
                    return i;
            return -1;
        }

        public int FindMax(int[] array)
        {
            //Check if the array is empty
            if (array.Length == 0)
                return -1;
           
            
           //First Consider array[0] means 10 as max
            int isMax = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                //Runtime complexity is O(n) linear of it input size
                //Check if array[0] means 10 is grether than array[i] means next number
                //If array[i] is greter than isMax we need to re assign isMax with latest max value.
                if (array[i] > isMax)
                    isMax = array[i]; // assign next max number into isMax
                    


            }
            return isMax;
        }

        public void ArrayReverse(int[] array)
        {
            if (array.Length == 0)
                Console.WriteLine("Invalid Operation!");

            for (int i = array.Length -1; i > 0; i--)
            {
                Insert(array[i]);
                //Console.WriteLine(array[i]);
                
            }
            Print();
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);

            }
        }
    }
}
