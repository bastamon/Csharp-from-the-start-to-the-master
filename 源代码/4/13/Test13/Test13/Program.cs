using System;
using System.Collections.Generic;
using System.Text;

namespace Test13
{
    class Program
    {
        static void Main(string[] args)
        {
            int T1 = 1112;										//声明整型变量T1
            int T2 = 927;										//声明整型变量T2
            bool result;										//声明bool型变量result
            //使result等于T1和T2进行大于或等于运算的返回值
            result = T2 >= T1;
            Console.WriteLine(result);								//输出结果
            Console.ReadLine();
        }
    }
}
