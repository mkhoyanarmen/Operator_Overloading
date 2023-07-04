using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            obj1.arr = new int[] { -5, 8, 46, 22 };

            A obj2 = new A();
            obj2.arr = new int[] { -53, 0, 6, -2 };

            A obj3 = new A();
            obj3 = obj1 + obj2;

            for (int i = 0; i < obj3.arr.Length; i++)
            {
                Console.Write(obj3.arr[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
