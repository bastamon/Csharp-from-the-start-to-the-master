using System;
using System.Collections.Generic;
using System.Text;
namespace Test04
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str1 = "芸烨湘枫";								//声明一个字符串Str1
            string Str2 = "用一生下载你";							//声明一个字符串Str2
            Console.WriteLine(String.Compare(Str1, Str2));				//输出字符串Str1与Str2比较后的返回值
            Console.WriteLine(String.Compare(Str1, Str1));				//输出字符串Str1与Str1比较后的返回值
            Console.WriteLine(String.Compare(Str2, Str1));				//输出字符串Str2与Str1比较后的返回值
            Console.ReadLine();
        }
    }
}
