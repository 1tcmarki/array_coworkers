using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_coworkers
{
    class Program
    {

        static void Kiir(int[] sz)
        {
            foreach (int item in sz)
            {
                Console.Write($"{item}");
            }
        }

        static void Main(string[] args)
        {
            //Zoltan : Tomb letrehozasa
            int[] szamok = { 1, 2, 3, 4, 5 };
            //Mate : Tomb adatainak osszeadasa
            Console.WdadriteLine("Máté");
            //Balint : Eredmenyek kiirasa
            Kiir(szamok);

           
        }
    }
}
