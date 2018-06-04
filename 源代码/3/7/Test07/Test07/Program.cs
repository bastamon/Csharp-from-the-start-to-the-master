using System;
using System.Collections.Generic;
using System.Text;
namespace Test07
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)					//for循环内的局部变量i
            {
                Console.WriteLine(i.ToString());			//输出0~20的数字
            }
            Console.ReadLine();
        }
    }
}
