using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzoftvertesztelesFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjon meg egy számot! ");
            double szam = Convert.ToDouble(Console.ReadLine());
            List<double> szamok = new List<double>();
            while (szam != 0)
            {
                szamok.Add(szam);
                foreach (var item in szamok)
                {
                    Console.Write(item + ", ");
                }
                Console.WriteLine();
                Console.Write("Adjon meg egy számot!");
                szam = Convert.ToDouble(Console.ReadLine());
            }
            double legnagyobb = szamok[0];
            foreach (var item in szamok)
            {
                if (legnagyobb < item)
                {
                    legnagyobb =item;
                }
            }
            Console.WriteLine($"A legnagyobb szám: {legnagyobb}");
            Console.ReadKey();
        }
    }
}
