﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr =new int[2,2]{ { 1, 2 }, { 3, 4 } };
            Console.Write("数组的行数为：");
            Console.Write(arr.Rank);
            Console.Write("\n");
            Console.Write("数组的列数为：");
            Console.Write(arr.GetUpperBound(arr.Rank - 1) + 1);
            Console.Write("\n");
            for (int i = 0; i < arr.Rank; i++)
            {
                string str = "";
                for (int j = 0; j < arr.GetUpperBound(arr.Rank - 1) + 1; j++)
                {
                    str = str + Convert.ToString(arr[i, j]) + " ";
                }
                Console.Write(str);
                Console.Write("\n");
            }
        }
    }
}
