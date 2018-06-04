using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 6, 7, 8, 9, 10 };
            int n = arr1.Length + arr2.Length;
            int[] arr3 = new int[n];
            for (int i = 0; i < arr3.Length; i++)
            {
                if (i < arr1.Length)
                    arr3[i] = arr1[i];
                else
                    arr3[i] = arr2[i - arr1.Length];
            }
            Console.WriteLine("合并后的一维数组：");
            foreach (int i in arr3)
                Console.Write("{0}", i + " ");
            Console.WriteLine();
            int[,] arr4 = new int[2, 5];  //定义一个要合并的二维数组
            for (int i = 0; i < arr4.Rank; i++)  //将两个一维数组循环添中到二维数组中
            {
                switch (i)
                {
                    case 0:
                        {
                            for (int j = 0; j < arr1.Length; j++)
                                arr4[i, j] = arr1[j];
                            break;
                        }
                    case 1:
                        {
                            for (int j = 0; j < arr2.Length; j++)
                                arr4[i, j] = arr2[j];
                            break;
                        }
                }
            }
            Console.WriteLine("合并后的二维数组：");
            for (int i = 0; i < arr4.Rank; i++)  //显示合并后的二维数组
            {
                for (int j = 0; j < arr4.GetUpperBound(arr4.Rank - 1) + 1; j++)
                    Console.Write(arr4[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
