using System;
using System.Collections.Generic;
using System.Text;

namespace Test24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ls = new string[5];							//创建具有5个项目的string类型数组
            ls[0] = "ls1";										//为数组第一项赋值
            ls[1] = "ls2";										//为数组第二项赋值
            ls[2] = "ls3";										//为数组第三项赋值
            ls[3] = "ls4";										//为数组第四项赋值
            ls[4] = "ls5";										//为数组第五项赋值
            Console.WriteLine(ls[0]);								//输出数组第一项
            Console.WriteLine(ls[1]);								//输出数组第二项
            Console.WriteLine(ls[2]);								//输出数组第三项
            Console.WriteLine(ls[3]);								//输出数组第四项
            Console.WriteLine(ls[4]);								//输出数组第五项
            Console.ReadLine();
        }
    }
}
