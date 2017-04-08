using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Gather
{
    class Program
    {
        static void Main(string[] args)
        {
//            Sort s = new Sort();
//            s.Sort_Array();

//            DoubleDimension ds = new DoubleDimension();
//            ds.row=3;
//            ds.col=2;
//            ds.Info();
//            SawTooth sa = new SawTooth();
//            sa.UTP();
//when you dont know the type of the array.you can use the array.createInstance(typeof(),size);however it can be overrided.
//            Array_1 asp  = new Array_1();
//            asp.Test1();
//pay attention to the person and the createInstance.
//            StaticArray sta = new StaticArray();
//            sta.PersonArray();
//            Copy_Clone_Arrays
//            cca = new Copy_Clone_Arrays();
//            cca.Copy_Array();
//            SortB sb = new SortB();
//            sb.Mmy();
            Person[] pn =
            {
                new Person { FN="Damon",LN="Hill"},
                new Person { FN="Niki",LN="Luanda"},
                new Person { FN="Cocoduo",LN="ppd"},
                new Person { FN="Niki",LN="Luanda"},
                new Person { FN="Niki",LN="Luanda"}
            };
            foreach (var p in pn)
            {
                Console.WriteLine(p.FN + "|" + p.FN);
            }
            Console.WriteLine("sorted:");
//            Array.Sort(pn);
            Parms_Array s = new Parms_Array();
            Person[] st=s.GetPersons(pn);
//            foreach (var p in st)
//            {
//                Console.WriteLine(p.FN+"|"+p.FN);
//            }
            s.DisplayArray(s.GetPersons(pn));
            Console.WriteLine("another way to show the sort Person.");
            s.DisplayInIEnum(s.GetPersons(pn));

            Console.Write("game is started now!\n");
            var game = new GameMoves();
            IEnumerator enumerator = game.Cross();
            while (enumerator.MoveNext())
            {
                enumerator = enumerator.Current as IEnumerator;
            }
            Console.ReadKey();
        }
    }
}
