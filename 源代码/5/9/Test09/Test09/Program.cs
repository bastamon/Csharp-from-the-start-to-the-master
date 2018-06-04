using System;
using System.Collections.Generic;
using System.Text;

namespace Test09
{
    class Program
    {
        static void Main(string[] args)
        {
            string StrA = "用一生下载你";									//声明字符串StrA
            string StrB = "";												//声明字符串StrB
            StrB = StrA.Substring(1, 4);										//截取字符串
            Console.WriteLine(StrB);										//输出截取后的字符串
            Console.ReadLine();
        }
    }
}
