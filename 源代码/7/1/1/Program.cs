using System;
using System.Collections.Generic;
using System.Text;

namespace _
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr ={ 1, 2, 3, 4, 5};
            foreach (int n in arr)
                Console.WriteLine("{0}", n + " ");
            Console.WriteLine();
        }
    }
}
