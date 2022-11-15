using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sortering.Tests
{
    [TestClass]
    public class Sortering_Tests
    {
        [TestMethod]
        public void TestBubbleSort()
        {
            int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
            BubbleSort.Sort(array);
            CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67}, array);
        }

        [TestMethod]
        public void TestInsertionSort()
        {
            int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
            InsertionSort.Sort(array);
            CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67}, array);
        }

        [TestMethod]
        public void TestSelectionSort()
        {
            int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
            SelectionSort.Sort(array);
            CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67}, array);
        }

        [TestMethod]
        public void TestQuickSort()
        {
            int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
            QuickSort.Sort(array);
            CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67}, array);
        }

        [TestMethod]
        public void TestMergeSort()
        {
            int[] array = new int[] { 34, 18, 15, 45, 67, 11 };
            MergeSort.Sort(array);
            CollectionAssert.AreEqual(new int[] { 11, 15, 18, 34, 45, 67}, array);
        }
    }
}