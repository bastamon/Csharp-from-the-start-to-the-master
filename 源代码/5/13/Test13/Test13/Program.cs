using System;
using System.Collections.Generic;
using System.Text;

namespace Test13
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "用一生下载你";					//声明一个字符串变量str1
            //声明一个字符串变量str2，并使用Remove方法从字符串str1的索引3出开始删除
            string str2 = str1.Remove(3);
            Console.WriteLine(str2);					//输出字符串str2
            Console.ReadLine();
        }
    }
}
