using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    /// <summary>
    /// 自定义类
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
        /// <summary>
        /// 定义一个virtual类型的方法，以便在派生类中重写该方法
        /// </summary>
        /// <returns>加法运算的和</returns>
        public virtual int Add()
        {
            return X + Y;
        }
    }
    /// <summary>
    /// 自定义类，该类继承自MyClass1
    /// </summary>
    class MyClass2 : MyClass1
    {
        /// <summary>
        /// 重写基类中的虚方法
        /// </summary>
        /// <returns>返回两个int型变量相加的和</returns>
        public override int Add()
        {
            int x=5;
            int y=7;
            return x + y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 myclass2 = new MyClass2();    //实例化MyClass2的对象
            MyClass1 myclass1 = (MyClass1)myclass2;//使用派生类MyClass2的对象实例化基类MyClass1的对象
            myclass1.X = 3;                         //为MyClass1类中的属性赋值
            myclass1.Y = 5;                         //为MyClass1类中的属性赋值
            Console.WriteLine(myclass2.Add());      //调用派生类中的方法
            Console.WriteLine(myclass1.Add());      //同样调用派生类中的方法
        }
    }
}
