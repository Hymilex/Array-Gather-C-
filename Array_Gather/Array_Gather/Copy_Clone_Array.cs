using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
    public class Copy_Clone_Arrays
    {
        public void Copy_Array()
        {
            int[] ia = {1, 2};
            int[] ia2 = (int[]) ia.Clone();
            //pay attention to the difference between copy()
            Person[] ps = {new Person {FN="a",LN="b"},new Person {FN="c",LN="d"} };
            Person[] psc = (Person[]) ps.Clone();
            //clone can create a new array however the copy must pass some limit parms and exited array.
        }
    }
}
