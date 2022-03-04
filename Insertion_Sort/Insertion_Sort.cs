using System;
using System.Collections.Generic;
using System.Text;

namespace Log_Algo
{
    class Insertion_Sort
 
    {
        public void Sorting()
        {
            int i;
            int[] a = new int[30]; // Array Declaration in C#  
            Console.Write("Enter the Number of values to be Sort : ");
            // read the string value (by default) and convert it in to integer  
            int n = Convert.ToInt16(Console.ReadLine());
            //Reading the values one by one  
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the No " + i + ":");
                // read the string value (by default) and convert it in to integer  
                a[i] = int.Parse(Console.ReadLine());   //convertToInt16/32/64 doing same work
            }
            //Sorting the values  
            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];   
                        a[j + 1] = temp;
                    }
                }
            }
             
            Console.Write("Ascending Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
            
        }
    }
}

