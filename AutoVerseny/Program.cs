using AutoVerseny.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerseny
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Feladat
            AutoVersenyRepo avrepo = new AutoVersenyRepo();
            //3. Feladat
            Console.WriteLine("3. Feladat: " + avrepo.SorokSzama());
            //4.feladat
            Console.WriteLine("4. Feladat: " + avrepo.Kereses("Fürge Ferenc", "Gran Prix Circuit", 3) + " másodperc");
            //5.  - 6. faladat
            Console.WriteLine("5. feladat: ");
            avrepo.KeresesNevAlapjan();
            Console.ReadKey();
        }
    }
}
