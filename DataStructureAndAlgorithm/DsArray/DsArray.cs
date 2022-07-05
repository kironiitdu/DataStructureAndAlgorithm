using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithm.DsArray
{
    public class DsArray
    {
        private int[] items;
        private int count;

        //Dynamic Array Creation
        public DsArray(int length)
        {
            items = new int[length];
        }

        public void Insert(int item)
        {
            items[count++] = item;
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
