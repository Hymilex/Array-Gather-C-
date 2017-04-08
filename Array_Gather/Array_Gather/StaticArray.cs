using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
    class StaticArray
    {
        public void PersonArray()
        {
            int[] lengths = {2,3};
            int[] lowerBounds = {1,10};
            Array racers = Array.CreateInstance(typeof(Person),lengths,lowerBounds);

            //setValue.
            racers.SetValue(new Person {FN="A",LN="B"},index1:1,index2:10);
            //pay attention to the differences.
            racers.SetValue(new Person { FN = "c", LN = "d" }, 1, 11);
            racers.SetValue(new Person {FN="c",LN="d"},1,12);
            racers.SetValue(new Person { FN = "c", LN = "d" }, 2, 10);
            racers.SetValue(new Person { FN = "c", LN = "d" }, 2, 11);
            racers.SetValue(new Person { FN = "c", LN = "d" }, 2, 12);

            Person[,] racer2 = (Person[,]) racers;
            Person first = racer2[1, 10];
            Console.Write("FisrtName:{0},LastName:{1}",racer2[1,10].FN,racer2[1,10].LN);
        }
    }
}
