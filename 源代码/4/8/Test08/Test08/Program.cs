using System;
using System.Collections.Generic;
using System.Text;

namespace Test08
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal L1 = 1981.00m;								//声明decimal类型变量L1
            decimal L2 = 1982.00m;								//声明decimal类型变量L2
            bool result;										//声明bool类型变量result
            //使result等于L1和L2进行相等运算后的返回值
            result = L1 == L2;
            Console.WriteLine(result);								//输出运行结果
            Console.ReadLine();
        }
    }
}
