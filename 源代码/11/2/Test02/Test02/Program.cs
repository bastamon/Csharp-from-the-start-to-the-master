using System;
using System.Collections.Generic;
using System.Text;
namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int Inum1;
                    int Inum2;
                    int Num;
                    Inum1 = 6000000;
                    Inum2 = 6000000;
                    Num = Inum1 * Inum2;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("引发OverflowException异常");
            }
            Console.ReadLine();
        }
    }
}
