using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 9, 27, 6, 18, 12, 21, 15 };
            foreach (int m in arr)
                Console.Write(m + " ");
            Console.WriteLine();
            int j, temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                j = i + 1;
                id:
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    goto id;
                }
                else
                    if (j < arr.Length - 1)
                    {
                        j++;
                        goto id;
                    }
            }
            foreach (int n in arr)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
