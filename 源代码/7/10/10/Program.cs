using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ArrayList List = new ArrayList(arr);
            Console.WriteLine("原ArrayList集合：");
            foreach (int i in List)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
            List.RemoveRange(0, 5);
            Console.WriteLine("删除元素后的ArrayList集合：");
            foreach (int i in List)
            {
                Console.Write(i.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
