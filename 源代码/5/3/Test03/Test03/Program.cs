using System;
using System.Collections.Generic;
using System.Text;
namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str1 = "用一生下载你";								//声明一个字符串变量Str1
            char Str2 = Str1[1];										//获取字符串Str1的第二个字符
            char Str3 = Str1[2];										//获取字符串Str1的第三个字符
            Console.WriteLine("字符串Str1中的第二个字符是：{0}", Str2);		//输出第二个字符
            Console.WriteLine("字符串Str1中的第三个字符是：{0}", Str3);		//输出第三个字符
            Console.ReadLine();
        }
    }
}
