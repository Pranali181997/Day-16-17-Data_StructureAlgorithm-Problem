using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Algo
{
    class Bubblesort
    {
        public void SortingBubble() //logic is if 7 6 9 5 6 4 -two num compare with each other-6 7 9 5 6 4 then sorted by iterating. 
        {
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };
            int t;
            Console.WriteLine("Original array :");
            foreach (int aa in a)
                Console.Write(aa + " ");
            for (int p = 0; p <= a.Length - 2; p++)
            {
                for (int i = 0; i <= a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in a)
                Console.Write(aa + " ");
            Console.Write("\n");

        }
    }
}
