using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("TM");
            list.Add("C# 2.0 从入门到应用开发");
            foreach (string str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}
