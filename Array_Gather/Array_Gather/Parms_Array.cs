using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
  public class Parms_Array
    {
        //return an array of the Person
        public Person[] GetPersons(Person[] a)
        {
            Array.Sort(a);
            return a;
        }

        public void DisplayArray(Person[] a)
        {
            foreach (var s in a)
            {
                Console.WriteLine("FirstName:{0}|LastName:{1}",s.FN,s.LN);
            }
        }

        public void DisplayInIEnum(Person[] persons)
        {
            //persons is a obj of the array with undefined.
            IEnumerator enumerator = persons.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Person p =(Person) enumerator.Current;
                Console.WriteLine(p.FN+"|"+p.LN);
            }
        }
    }
}
