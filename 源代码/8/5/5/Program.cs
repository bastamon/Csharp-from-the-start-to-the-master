using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    public class Date
    {
        private int Day = 7;
        public int day
        {
            get
            {
                return Day;
            }
            set
            {
                if ((value > 0) && (value < 8))
                {
                    Day = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
