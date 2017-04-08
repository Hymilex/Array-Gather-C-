using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
   public class DoubleDimension
    {
        //type[,] arrayName
        //create the rows and cols.
        private int r=0;
        private int c=0;
        //geters and setters.
        public int row
        {
            get { return r; }
            set { r = value; }
        }

        public int col
        {
            get { return c; }
            set { c = value; }
        }

        public string Name;
        public int id;
        public void Info()
        {
            Console.WriteLine("please input the strings.");
            string[,] Info = new string[row, col];
            Console.WriteLine("please input the id and name:");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    int tmp = c+1;
                    if (tmp%2 == 0)
                    {
                        Info[r, c] = Convert.ToString(Console.ReadLine());
                    }
                    else
                    {
                        Info[r, c] = Convert.ToString(Console.ReadLine());
                    }
                }
            }

            //output
            Console.WriteLine("output:");
            for (var i = 0; i < row; i++)
            {
                Console.Write("----------------------\n");
                for (var j = 0; j < col; j++)
                {
                    int h = j + 1;
                    if (h%2 == 0)
                    {
                        Console.Write("|Name:{0}|", Info[i, j]);
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Write("|ID:{0}",Info[i,j]);
                    }
                }
            }
            Console.WriteLine("--------------------\n");
        }

        public void PrintPop()
        {

        }
    }
}
