using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    /// <summary>
    /// 自定义类，封装加数和被加数属性
    /// </summary>
    class MyClass1
    {
        private int x = 0;                                 //定义int型变量，作为加数
        private int y = 0;                                 //定义int型变量，作为被加数
        /// <summary>
        /// 加数
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        /// <summary>
        /// 被加数
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
    /// <summary>
    /// 自定义类，封装求和方法
    /// </summary>
    class MyClass2
    {
        MyClass1 myclass1 = new MyClass1();      //实例化MyClass1的对象
        /// <summary>
        /// 求和
        /// </summary>
        /// <returns>加法运算和</returns>
        public int Add()
        {
            return myclass1.X + myclass1.Y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 myclass1 = new MyClass1();    //实例化MyClass1的对象
            MyClass2 myclass2 = new MyClass2();    //实例化MyClass2的对象
            myclass1.X = 3;                        //为MyClass1类中的属性赋值
            myclass1.Y = 5;                        //为MyClass1类中的属性赋值
            Console.WriteLine(myclass2.Add());     //调用MyClass2类中的Add方法求和
        }
    }
}
