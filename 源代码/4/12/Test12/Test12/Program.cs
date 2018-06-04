using System;
using System.Collections.Generic;
using System.Text;

namespace Test12
{
    class Program
    {
        static void Main(string[] args)
        {
            int X1 = 12;										//声明整型变量X1
            int X2 = 9;											//声明整型变量X2
            bool result;										//声明bool型变量result
            //使result等于X1和X2进行小于或等于运算的返回值
            result = X2 <= X1;
            Console.WriteLine(result);								//输出结果
            Console.ReadLine();
        }
    }
}
