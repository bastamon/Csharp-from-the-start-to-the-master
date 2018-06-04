using System;
using System.Collections.Generic;
using System.Text;

namespace Test14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;										//声明一个整型的变量num1
            int num2 = 85;										//声明一个整型的变量num2
            bool iseven;										//声明一个bool类型的变量iseven
            iseven = (num1 & num2) == 0;						//获取两个变量“与”运算后的返回值
            Console.WriteLine(iseven);							//输出结果
            Console.ReadLine();
        }
    }
}
