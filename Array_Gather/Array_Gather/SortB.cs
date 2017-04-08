using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
    class SortB
    {
        //use the quick method to sort the parms in the array.
        public void Mmy()
        {
            string[] names = {"A","b","C","d"};
            Array.Sort(names);

            foreach (var name in names)
            {
                Console.Write("name:{0}\t|",name);
            }
        }
    }
}
