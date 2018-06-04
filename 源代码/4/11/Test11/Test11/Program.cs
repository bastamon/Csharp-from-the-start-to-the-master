using System;
using System.Collections.Generic;
using System.Text;

namespace Test11
{
    class Program
    {
        static void Main(string[] args)
        {
            int F1 = 18;										//声明整型变量F1
            int F2 = 8;											//声明整型变量F2
            bool result;										//声明bool型变量result
            //使result等于F1和F2进行大于运算的返回值
            result = F1 > F2;
            Console.WriteLine(result);								//输出结果
            Console.ReadLine();
        }
    }
}
