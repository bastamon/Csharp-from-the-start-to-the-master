using System;
using System.Collections.Generic;
using System.Text;

namespace Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            int shj1 = 45;										//声明整型变量shj1，并赋值为45
            int shj2 = 5;										//声明整型变量shj2，并赋值为5
            int ls;											//声明整型变量ls
            ls = shj1 / shj2;									//使ls的值为shj1除以shj2得到的值
            Console.WriteLine(ls.ToString());
            Console.Read();
        }
    }
}
