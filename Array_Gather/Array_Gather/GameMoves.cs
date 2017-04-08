using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
    class GameMoves
    {
        //this mainly introduce the yield return IEnumerator
        private IEnumerator cross;
        private IEnumerator circle;

        public GameMoves()
        {
            cross = Cross();
            circle = Circle();
        }

        private int move=0;
        const int maxMoves = 9;
        public IEnumerator Cross()
        {
            while (true)
            {
                Console.WriteLine("Cross,move {0}",move);
                if (++move >= maxMoves)
                {
                    yield break;
                }
                yield return circle;
            }
        }

        public IEnumerator Circle()
        {
            while (true)
            {
                Console.WriteLine("Circle,move {0}",move);
                if (++move >= maxMoves)
                {
                    yield break;
                }
                yield return cross;
            }
        }
    }
}
