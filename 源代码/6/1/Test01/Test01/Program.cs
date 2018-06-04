using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 927;											//声明一个int类型变量i
            if (i > 927)											//调用if语句判断I是否大于927
            {
                Console.WriteLine("i大于927");						//如果大于927则输出“I大于927”
            }
            else												//否则
            {
                Console.WriteLine("i不大于927");					//输出“I不大于927”
            }
            Console.ReadLine();
        }
    }
}
