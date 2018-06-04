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
            foreach (int n in arr)
                Console.Write("{0}", n + " ");
            Console.WriteLine();
            for (int i = 0; i < 6; ++i)
            {
                int temp = arr[i];
                int j = i;
                while ((j > 0) && (arr[j - 1] > temp))
                {
                    arr[j] = arr[j - 1];
                    --j;
                }
                arr[j] = temp;
            }
            Console.WriteLine("排序后结果为：");
            foreach (int n in arr)
                Console.Write("{0}", n + " ");
            Console.WriteLine();
        }
    }
}
