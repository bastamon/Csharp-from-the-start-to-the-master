using System;
using System.Collections.Generic;
using System.Text;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str1 = "芸烨湘枫";						//声明一个字符串Str1 
            string Str2 = "用一生下载你";					//声明一个字符串Str2
            Console.WriteLine(Str1.Equals(Str2));				//用Equals方法比较字符串Str1和Str2
            Console.WriteLine(String.Equals(Str1, Str2));		//用Equals方法比较字符串Str1和Str2
            Console.ReadLine();
        }
    }
}
