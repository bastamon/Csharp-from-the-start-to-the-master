﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test16
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "用一生下载你";					//声明一个字符串变量str1并初始化
            char[] str = new char[100];					//声明一个字符数组str
            //将字符串str从索引1开始的4个字符串复制到字符数组str中
            str1.CopyTo(1, str, 0, 4);
            Console.WriteLine(str);						//输出字符数组中的内容
            Console.ReadLine();
        }
    }
}
