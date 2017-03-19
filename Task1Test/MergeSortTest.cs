using System;
using NUnit.Framework;
using static Task1.MergeSort;

namespace Task1Test
{
    [TestFixture]
    public class MergeSortTest
    {
        [TestCase(null)]
        public void Sort_ThrowArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => Sort(array));
        }

        [TestCase( new int[] {9, 10, 2, 4, 6, 7, 8} ,ExpectedResult = new int[] { 2, 4, 6, 7, 8, 9, 10})]
        public int[] SortMaster_PositivTest(int[] array)
        {
            return SortMaster_PositivTest(array);
        }

    }
}
