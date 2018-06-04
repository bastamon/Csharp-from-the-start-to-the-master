using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入动态数组的行数:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("请输入动态数组的列数:");
            int col = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, col];
            Console.WriteLine("结果:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(i+j.ToString()+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
