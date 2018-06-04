using System;
using System.Collections.Generic;
using System.Text;

namespace Test20
{
    class Program
    {
        static void Main(string[] args)
        {
            uint intmax = 4294967295;							//声明uint类型变量intmax
            uint bytemask;										//声明uint类型变量bytemask
            bytemask = intmax << 8;								//使intmax左移8次
            Console.WriteLine(bytemask);							//输出结果
            Console.ReadLine();
        }
    }
}
