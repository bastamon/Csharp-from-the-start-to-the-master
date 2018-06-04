using System;
using System.Collections.Generic;
using System.Text;

namespace Test14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "芸烨湘枫";					//声明一个字符串变量str1，并初始化
            //声明一个字符串变量str2，并使用Remove方法从字符串str1的索引1处开始删除2个字符
            string str2 = str1.Remove(1, 2);
            Console.WriteLine(str2);					//输出字符串str2
            Console.ReadLine();
        }
    }
}
