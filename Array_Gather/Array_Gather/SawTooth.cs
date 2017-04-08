using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
    class SawTooth
    {
        public void UTP()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[2] {1, 2};
            jagged[1] = new int[6] {12, 2, 3, 4, 5, 6};
            jagged[2] = new int[3] {6, 9, 4};

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int ele = 0; ele < jagged[row].Length; ele++)
                {
                    Console.WriteLine("row:{0},element:{1},value:{2}",row,ele,jagged[row][ele]);
                }
            }
        }
    }
}
