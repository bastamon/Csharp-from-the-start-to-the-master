using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    interface ImyInterface1
    {
        /// <summary>
        /// 求和方法
        /// </summary>
        /// <returns>加法运算的和</returns>
        int Add();
    }
    interface ImyInterface2
    {
        /// <summary>
        /// 求和方法
        /// </summary>
        /// <returns>加法运算的和</returns>
        int Add();
    }
    class myClass : ImyInterface1, ImyInterface2    //继承接口
    {
        /// <summary>
        /// 求和方法
        /// </summary>
        /// <returns>加法运算的和</returns>
        int ImyInterface1.Add()                     //显式接口成员实现
        {
            int x = 3;
            int y = 5;
            return x + y;
        }
        /// <summary>
        /// 求和方法
        /// </summary>
        /// <returns>加法运算的和</returns>
        int ImyInterface2.Add()                      //显式接口成员实现
        {
            int x = 3;
            int y = 5;
            int z = 7;
            return x + y + z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass myclass = new myClass();          //实例化接口继承类的对象
            ImyInterface1 imyinterface1 = myclass;    //使用接口继承类的对象实例化接口
            Console.WriteLine(imyinterface1.Add());   //使用接口对象调用接口中方法
            ImyInterface2 imyinterface2 = myclass;    //使用接口继承类的对象实例化接口
            Console.WriteLine(imyinterface2.Add());   //使用接口对象调用接口中方法
        }
    }
}
