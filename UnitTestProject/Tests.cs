using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_2_Testirovanie;

namespace White_and_Black_Box
{
    [TestClass]
    public class Tests
    {
        ////////////////////////////////////////////////////////////////// ТЕСТИРОВАНИЕ бЕЛОГО ЯЩИКА
        [TestMethod]
        public void Test_Path_1() //неотсортированный массив
        {
            int[] arr1 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] test1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] actual = Sort.BubbleSort(arr1);

            CollectionAssert.AreEqual(test1, actual);
        }

        [TestMethod]
        public void Test_Path_2() //отсортированный массив
        {
            int[] arr1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] test1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] actual = Sort.BubbleSort(arr1);

            CollectionAssert.AreEqual(test1, actual);
        }

        [TestMethod]
        public void Test_Path_3() //массив из 1 элемента
        {
            int[] arr1 = new int[] { 5 };
            int[] test1 = new int[] { 5 };

            int[] actual = Sort.BubbleSort(arr1);

            CollectionAssert.AreEqual(test1, actual);
        }

        [TestMethod]
        public void Test_Path_4() //пустой массив
        {
            int[] arr1 = new int[0];
            int[] test1 = new int[0];

            int[] actual = Sort.BubbleSort(arr1);

            CollectionAssert.AreEqual(test1, actual);
        }

        ///////////////////////////////////////////////////////////////// ТЕСТИРОВАНИЕ ЧЕРНОГО ЯЩИКА
        [TestMethod]
        public void Test_Empty_Array() //пустой массив
        {
            int[] arr1 = new int[0];
            int[] test1 = new int[0];

            int[] actual = Sort.BubbleSort(arr1);

            CollectionAssert.AreEqual(test1, actual);
        }

        [TestMethod]
        public void Test_Array_One() //массив из 1 элемента
        {
            int[] arr1 = new int[] { 9 };
            int[] test1 = new int[] { 9 };

            int[] actual = Sort.BubbleSort(arr1);

            CollectionAssert.AreEqual(test1, actual);

        }

        [TestMethod]
        public void Test_Sorted_Array() //отсортированный массив
        {
            int[] arr1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] test1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] actual = Sort.BubbleSort(arr1);

            CollectionAssert.AreEqual(test1, actual);
        }

        [TestMethod]
        public void Test_NotSorted_Array() //неотсортированный массив
        {
            int[] arr1 = new int[] { 7, 2, 9, 3, 4, 1, 0, 5, 6, 8 };
            int[] test1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] actual = Sort.BubbleSort(arr1);

            CollectionAssert.AreEqual(test1, actual);
        }
    }
}
