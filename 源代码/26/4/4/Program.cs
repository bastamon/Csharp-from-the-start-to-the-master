﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread;									//声明线程
            //用线程起始点的ThreadStart委托创建该线程的实例
            myThread = new Thread(new ThreadStart(createThread));
            myThread.Start();									//启动线程
            myThread.Abort();									//终止线程
        }
        public static void createThread()
        {
            Console.Write("线程实例");
        }
    }
}
