using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
   public class Person: IComparable<Person>
    {
        private string FirstName;
        private string LastName;
        //getters and setters.
        public string FN
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string LN
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public int CompareTo(Person other)
        {
            if (other == null) throw new ArgumentNullException("other");
            int result = this.LN.CompareTo(other.LN);
            if (result == 0)
            {
                result = this.FN.CompareTo(other.FN);
            }
            return result;
        }
    }
}
