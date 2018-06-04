using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        ~Program()
        {
            Console.WriteLine("析构函数自动调用");
        }
        static void Main(string[] args)
        {
            Program program = new Program();           //使用构造函数实例化Program对象
        }
    }
}
