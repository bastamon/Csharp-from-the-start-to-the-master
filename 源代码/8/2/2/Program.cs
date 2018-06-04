using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("结果为：" + Program.Add(3, 5));
        }
    }
}
