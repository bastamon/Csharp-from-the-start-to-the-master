using System;
using System.Collections.Generic;
using System.Text;
namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object obj = null;
                int N = (int)obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine("捕获异常："+ex);
            }
            Console.ReadLine();
        }
    }
}
