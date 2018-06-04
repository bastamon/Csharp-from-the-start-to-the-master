using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 3] { { 1, 3, 5 }, { 2, 4, 6 } };
            int[] arr2 = new int[3];
            int[] arr3 = new int[3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (i)
                    {
                        case 0: arr2[j] = arr1[i, j]; break;
                        case 1: arr3[j] = arr1[i, j]; break;
                    }
                }
            }
            Console.WriteLine("数组一：");
            foreach (int n in arr2)
                Console.Write(n + " ");
            Console.WriteLine();
            Console.WriteLine("数组二：");
            foreach (int n in arr3)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }
}
