using System;
using System.Collections.Generic;
using System.Text;

namespace Test10
{
    class Program
    {
        static void Main(string[] args)
        {
            int U1 = 1112;										//声明整型变量U1
            int U2 = 927;										//声明整型变量U2
            bool result;										//声明bool型变量result
            //使result等于U1和U2进行小于运算的返回值
            result = U1 < U2;
            Console.WriteLine(result);								//输出结果
            Console.ReadLine();
        }
    }
}
