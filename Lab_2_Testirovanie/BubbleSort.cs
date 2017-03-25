using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Testirovanie
{
    public class Sort
    {
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
