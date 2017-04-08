using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
    public class Sort
    {
        //member variable
        public string name;
        public int id;
        //method 
        public void Sort_Array()
        {
            Console.WriteLine("please input the array size:");
            int num = Convert.ToInt32(Console.ReadLine());
            //type[] arrayName
            int[] arr = new int[num];
            Console.WriteLine("fill the nummber of the arraylist:");
            for (int i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("input end.");

            for (int i = 0; i < num; ++i)
            {
                int temp = arr[i];
                int j = i;
                while ((j > 0) && (arr[j - 1] > temp))
                {
                    arr[j] = arr[j - 1];
                    --j;
                }
                arr[j] = temp;//it's important to control.
            }
            //output
            Console.WriteLine("output the line:");
            foreach (int n in arr)
            {
                Console.WriteLine("{0}",n);
            }
        }
    }
}
