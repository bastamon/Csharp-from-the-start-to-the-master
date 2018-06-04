using System;
using System.Collections.Generic;
using System.Text;

namespace Test09
{
    class Program
    {
        static void  ReturnName()
        {
            string name = "用一生下载你";
            Console.WriteLine(name);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            try
            {
                ReturnName();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
