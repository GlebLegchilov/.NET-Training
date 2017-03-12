using System;
using System.Linq;

namespace MergeSort
{

    /// <summary>
    /// Class sort unsorted array
    /// </summary>
    static public class SortClass
    {

        /// <summary>
        /// Sorts an array by MergeSort
        /// </summary>
        /// <param name="array">Unsorted array</param>
        /// <returns>Sorted array</returns>
        static public Int32[] Sort(Int32[] array)
        {
            if (array.Length == 1)
                return array;
            int mid_point = array.Length / 2;
            return Merge(Sort(array.Take(mid_point).ToArray()), Sort(array.Skip(mid_point).ToArray()));
        }

        /// <summary>
        /// Merge two arrays
        /// </summary>
        /// <param name="firstArray">First array's half</param>
        /// <param name="secondArray">Second array's half</param>
        /// <returns>Merged array</returns>
        static private Int32[] Merge(Int32[] firstArray, Int32[] secondArray)
        {
            Int32 a = 0, b = 0;
            Int32[] mergedArray = new Int32[firstArray.Length + secondArray.Length];
            for (int i = 0; i < firstArray.Length + secondArray.Length; i++)
            {
                if (b.CompareTo(secondArray.Length) < 0 && a.CompareTo(firstArray.Length) < 0)
                    if (firstArray[a].CompareTo(secondArray[b]) > 0)
                        mergedArray[i] = secondArray[b++];
                    else
                        mergedArray[i] = firstArray[a++];
                else
                    if (b < secondArray.Length)
                    mergedArray[i] = secondArray[b++];
                else
                    mergedArray[i] = firstArray[a++];
            }
            return mergedArray;
        }
    }
}
