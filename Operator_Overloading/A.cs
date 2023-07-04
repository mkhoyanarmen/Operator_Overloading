using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    internal class A
    {
        public int[] arr { get; set; }

        public static A operator +(A obj1, A obj2)
        {
            A res = new A();
            res.arr = new int[obj1.arr.Length];
            
            for (int i = 0; i < obj1.arr.Length; i++)
            {
                res.arr[i] = obj1.arr[i] + obj2.arr[i];
            }
            return res;
        }
    }
}
