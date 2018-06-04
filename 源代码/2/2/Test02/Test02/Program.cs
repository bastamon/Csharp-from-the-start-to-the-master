using System;
using System.Collections.Generic;
using System.Text;
using N1;
namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            A oa = new A();
            oa.Myls();
        }
    }
}
namespace N1									    //建立命名空间N1
{
    class A                                         //命名空间N1中的类A
    {
        public void Myls()
        {
            Console.WriteLine("用一生下载你");
            Console.ReadLine();
        }
    }
}