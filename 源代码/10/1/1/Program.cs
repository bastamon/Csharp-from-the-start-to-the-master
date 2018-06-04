using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    interface ImyInterface
    {
        /// <summary>
        /// 编号（可读可写）
        /// </summary>
        string ID
        {
            get;
            set;
        }
        /// <summary>
        /// 姓名（可读可写）
        /// </summary>
        string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 显示定义的编号和姓名
        /// </summary>
        void ShowInfo();
    }
    class Program:ImyInterface//继承自接口
    {
        string id = "";
        string name = "";
        /// <summary>
        /// 编号
        /// </summary>
        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// 显示定义的编号和姓名
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("编号\t 姓名");
            Console.WriteLine(ID + "\t " + Name);
        }
        static void Main(string[] args)
        {
            Program program = new Program();               //实例化Program类对象
            ImyInterface imyinterface = program;           //使用派生类对象实例化接口ImyInterface
            imyinterface.ID = "TM";                        //为派生类中的ID属性赋值
            imyinterface.Name = "C# 2.0从入门到应用开发";  //为派生类中的Name属性赋值
            imyinterface.ShowInfo();                       //调用派生类中方法显示定义的属性值
        }
    }
}
