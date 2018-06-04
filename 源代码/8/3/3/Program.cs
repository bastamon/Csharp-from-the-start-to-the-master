using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("结果为：" + program.Add(3, 5));
        }
    }
}
