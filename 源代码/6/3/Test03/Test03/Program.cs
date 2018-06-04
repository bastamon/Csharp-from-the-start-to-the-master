using System;
using System.Collections.Generic;
using System.Text;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyStr = "用一生下载你";				//声明一个字符串变量MyStr并初始化
            switch (MyStr)							//调用switch语句
            {
                //如果MyStr的值是“用一生下载你”，在执行分支1
                case "用一生下载你": Console.WriteLine("用一生下载你"); break;
                //如果MyStr的值是“一生所爱”，在执行分支2
                case "一生所爱": Console.WriteLine("一生所爱"); break;
                //如果MyStr的值是“芸烨湘枫”，在执行分支3
                case "芸烨湘枫": Console.WriteLine("芸烨湘枫"); break;
                //如果MyStr的值是都不符合以上分支的内容，则执行default语句
                default: Console.WriteLine("无字符"); break;
            }
            Console.ReadLine();
        }
    }
}
