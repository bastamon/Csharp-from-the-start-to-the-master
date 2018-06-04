using System;
using System.Collections.Generic;
using System.Text;
namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 112;
            object obj = i;
            Console.WriteLine("装箱操作：值为{0}，装箱之后对象为{1}", i, obj);
            int j = (int)obj;
            Console.WriteLine("拆箱操作：装箱对象为{0}，值为{1}", obj, j);
            Console.ReadLine();
        }
    }
}
