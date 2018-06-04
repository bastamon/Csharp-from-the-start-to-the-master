using System;
using System.Collections.Generic;
using System.Text;

namespace Test16
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;										//声明一个整型的变量num1
            int num2 = 85;										//声明一个整型的变量num2
            int iseven;											//声明一个整型的变量iseven
            //获取两个变量“异或”运算后的返回值
            iseven = (num1 ^ num2);
            Console.WriteLine(iseven);							//输出结果
            Console.ReadLine();
        }
    }
}
