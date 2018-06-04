using System;
using System.Collections.Generic;
using System.Text;

namespace Test18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Bls = false;									//声明一个bool类型变量Bls
            int Inum = 20;										//声明一个整型变量Inum
            bool result;										//声明一个bool类型变量result
            result = Bls | (Inum < 30);								//获取布尔“或”运算后的返回值
            Console.WriteLine(result);								//输出结果
            Console.ReadLine();
        }
    }
}
