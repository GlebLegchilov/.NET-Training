using System;
using MergeSort;

namespace ConsoleMergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = new Int32[100];
            Random rd = new Random();
            for (int i = 0; i < array.Length; ++i)
                array[i] = rd.Next(1, 1001);
            
            for(int i = 0; i < array.Length; ++i)
                System.Console.Write(array[i] + " ");
            System.Console.WriteLine();
            System.Console.WriteLine();

            array = MergeSort.SortClass.Sort(array);

            for (int i = 0; i < array.Length; ++i)
                System.Console.Write(array[i] + " ");

            Console.ReadKey();

        }
    }
}
