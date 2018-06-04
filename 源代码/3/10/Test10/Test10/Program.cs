using System;
using System.Collections.Generic;
using System.Text;

namespace Test10
{
    class Program
    {
        const int i = 927;
        static void Main(string[] args)
        {
            try
            {
                i = 112;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
