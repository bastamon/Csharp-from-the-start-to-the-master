﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();			//实例化Hashtable对象
            hashtable.Add("id", "BH0001");					//向Hashtable哈希表中添加元素
            hashtable.Add("name", "TM");
            hashtable.Add("sex", "男");
            Console.WriteLine(hashtable.ContainsValue("id"));	//判断Hashtable哈希表中是否包含指定的键值
        }
    }
}
