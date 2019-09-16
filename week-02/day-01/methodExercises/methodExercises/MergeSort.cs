using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 1, 10, 4, 3, 2, 7, 8, 23 };
            mergeSort(ref arr);
            display(arr);
        }
        public static void display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void mergeSort(ref int[] arr)
        {
            if (arr.Length < 2) { return; }
            int[] arr1 = new int[arr.Length / 2];
            int[] arr2 = new int[arr.Length - arr.Length / 2];
            Array.Copy(arr, arr1, arr.Length / 2);
            Array.Copy(arr, arr.Length / 2, arr2, 0, arr.Length - arr.Length / 2);
            mergeSort(ref arr1);
            mergeSort(ref arr2);
            int k = 0; //arr1 index
            int l = 0; //arr2 index
            int j = 0; //arr index
            while ((k != arr1.Length) && (l != arr2.Length))
            {
                if (arr1[k] < arr2[l])
                {
                    arr[j] = arr1[k];
                    k++;
                    j++;
                }
                else
                {
                    arr[j] = arr2[l];
                    l++;
                    j++;
                }
            }
            if (k != arr1.Length)
            {
                while (k != arr1.Length)
                {
                    arr[j] = arr1[k];
                    k++;
                    j++;
                }
            }
            else if (l != arr2.Length)
            {
                while (l != arr2.Length)
                {
                    arr[j] = arr2[l];
                    l++;
                    j++;
                }
            }
        }
    }
}