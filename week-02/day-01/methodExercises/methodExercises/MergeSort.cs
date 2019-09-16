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
        public static void assign(ref int[] arr1, ref int[] arr2, ref int index1, ref int index2)
        {
            arr1[index1] = arr2[index2];
            index1++;
            index2++;
        }
        public static void mergeSort(ref int[] arr)
        {
            if (arr.Length < 2) { return; }
            int halfLength = arr.Length / 2;
            int[] arr1 = new int[halfLength];
            int[] arr2 = new int[arr.Length - halfLength];
            Array.Copy(arr, arr1, halfLength);
            Array.Copy(arr, halfLength, arr2, 0, arr.Length - halfLength);
            mergeSort(ref arr1);
            mergeSort(ref arr2);
            int arr1Index = 0; 
            int arr2Index = 0; 
            int arrIndex = 0; 
            while ((arr1Index != arr1.Length) && (arr2Index != arr2.Length))
            {
                if (arr1[arr1Index] < arr2[arr2Index])
                {
                    assign(ref arr, ref arr1, ref arrIndex, ref arr1Index);
                }
                else
                {
                    assign(ref arr, ref arr2, ref arrIndex, ref arr2Index);
                }               
            }
            if (arr1Index != arr1.Length)
            {
                while (arr1Index != arr1.Length)
                {
                    assign(ref arr, ref arr1, ref arrIndex, ref arr1Index);
                }
            }
            else if (arr2Index != arr2.Length)
            {
                while (arr2Index != arr2.Length)
                {
                    assign(ref arr, ref arr2, ref arrIndex, ref arr2Index);
                }
            }
        }
    }
}