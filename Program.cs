using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Log_Algo;

namespace Log_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the algorithm problems");

            //Insertion_Sort insertion = new Insertion_Sort();
            //insertion.Sorting();

            //Bubblesort bubblesort = new Bubblesort();
            //bubblesort.SortingBubble();

            //Anagram.Anagram1();

            //MergeSortProggram abc = new MergeSortProggram();
            //abc.MergeSort();

            // PrimeNumBetween1_1000.primeNum();

            //Console.WriteLine("Enter String to find Permutation ");
            //string str = Console.ReadLine();
            //int n = str.Length;
            //Permutation.Permutate(str, 0, n - 1);

            Anagram_Plindrom anagram_Plindrom = new Anagram_Plindrom();
            anagram_Plindrom.CheckPrime();
        }

    }
}