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
        public double Add(int x, double y)
        {
            return x + y;
        }
        public int Add(int x, int y,int z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int x = 3;
            int y = 5;
            int z = 7;
            double y2 = 5.5;
            Console.WriteLine(x + "+" + y + "=" + Program.Add(x, y));
            Console.WriteLine(x + "+" + y2 + "=" + program.Add(x, y2));
            Console.WriteLine(x + "+" + y + "+" + z + "=" + program.Add(x, y, z));
        }
    }
}
