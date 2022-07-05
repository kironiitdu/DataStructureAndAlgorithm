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
            numbers.Print();

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
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);

            }
            Console.ReadLine();
           
        }
    }
}
