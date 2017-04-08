using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
    class Array_1
    {
        public void Test1()
        {
            Array intArray1 = Array.CreateInstance(typeof(int),5);
            for (int i = 0; i < 5; i++)
            {
                intArray1.SetValue(33,i);//set the value.
            }
            //output
            for (int j = 0; j < 5; j++)
            {
                Console.Write("-----------");
                Console.Write(intArray1.GetValue(j));
            }
        }
    }
}
