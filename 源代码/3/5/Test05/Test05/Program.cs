using System;
using System.Collections.Generic;
using System.Text;
namespace Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2008;
            object obj = i;
            Console.WriteLine("1、i的值为{0}，装箱之后的对象为{1}", i, obj);
            i = 927;
            Console.WriteLine("2、i的值为{0}，装箱之后的对象为{1}", i, obj);
            Console.ReadLine();
        }
    }
}
