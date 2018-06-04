using System;
using System.Collections.Generic;
using System.Text;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal R1 = (decimal)1112.82;								//声明整型变量R1，并赋值为1112.82
            decimal R2 = (decimal)9270.81;								//声明整型变量R2，并赋值为9270.81
            decimal R3;										//声明整型变量R3
            R3 = R2 - R1;										//R3的值为R2减去R1得到的值
            Console.WriteLine(R3.ToString());
            Console.Read();
        }
    }
}
