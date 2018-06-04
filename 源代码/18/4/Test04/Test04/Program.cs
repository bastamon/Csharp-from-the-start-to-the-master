using System;
using System.Collections.Generic;
using System.Text;

namespace Test04
{
    class Program
    {
        partial class Mclass
        {
            public void Hello()
            {
                Console.WriteLine("用一生下载你");
            }
        }
        partial class Mclass
        {
            public void Hi()
            {
                Console.WriteLine("芸烨湘枫");
            }
        }
        static void Main(string[] args)
        {
            Mclass myclass = new Mclass();
            myclass.Hello();
            myclass.Hi();
            Console.ReadLine();
        }
    }
}
