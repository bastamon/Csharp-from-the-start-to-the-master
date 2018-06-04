using System;
using System.Collections.Generic;
using System.Text;

namespace Test18
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 1000;							//声明一个int类型变量Num并初始化为1000
            //实例化一个StringBuilder类，并初始化为“用一生下载你”
            StringBuilder LS = new StringBuilder("用一生下载你", 100);
            LS.Append("VS芸烨湘枫");					//使用Append方法将字符串追加到LS的末尾
            Console.WriteLine(LS);					//输出LS
            //使用AppendFormat方法将字符串按照指定的格式追加到LS的末尾
            LS.AppendFormat("{0:C}", Num);
            Console.WriteLine(LS);					//输出LS
            LS.Insert(0, "名称：");						//使用Insert方法将“名称：”追加到LS的开头
            Console.WriteLine(LS);					//输出LS
            //使用Remove方法从LS中删除索引15以后的字符串
            LS.Remove(15, LS.Length - 15);
            Console.WriteLine(LS);					//输出LS
            //使用Replace方法将“名称：”替换成“一生所爱”
            LS.Replace("名称", "一生所爱");
            Console.WriteLine(LS);					//输出LS
            Console.ReadLine();
        }
    }
}
