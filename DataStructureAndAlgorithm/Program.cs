using System;


namespace DataStructureAndAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            DSArray numbers = new DSArray(3);
            numbers.Insert(5);
            numbers.Insert(10);
            numbers.Insert(15);
            numbers.Insert(20);
            numbers.RemoveAt(3);
            numbers.Print();

            int[] arrayNumbers = { 10, 15, 20 };
            //Extent New Array Length
            int[] newArrayNumbers = new int[arrayNumbers.Length+1];
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


        public void Insert(int item)
        {
            items[count++] = item;

            if (items.Length == count)
            {
                int[] newItems = new int[count * 2];
                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                items = newItems;
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
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);

            }
        }
    }
}
