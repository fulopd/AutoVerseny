using AutoVerseny.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerseny.Repository
{
    class AutoVersenyRepo
    {
        List<AutoVersenyModel> autoVersenyLista;

        public AutoVersenyRepo()
        {
            autoVersenyLista = new List<AutoVersenyModel>();
            Beolvas();
        }

        private void Beolvas()
        {
            using (StreamReader sr = new StreamReader("autoverseny.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    autoVersenyLista.Add(new AutoVersenyModel(sor[0],
                                                              sor[1],
                                                              Convert.ToInt32(sor[2]),
                                                              sor[3],
                                                              sor[4],
                                                              Convert.ToInt32(sor[5])
                                                              ));
                }

            }
        }

        public int SorokSzama()
        {
            return autoVersenyLista.Count();
        }



        public int Kereses(string versenyzo, string palya, int kor)
        {
            var eredmeny = autoVersenyLista.SingleOrDefault(x => x.versenyzo == versenyzo &&
                                                            x.palya == palya &&
                                                            x.kor == kor);

            return eredmeny.korido;
        }

        public void KeresesNevAlapjan()
        {
            AutoVersenyModel minKorido = new AutoVersenyModel();
            Console.WriteLine("Kérem egy versenyző nevét: ");
            string nev = Console.ReadLine();

            //var eredmeny = autoVersenyLista.Where(x => x.versenyzo == nev).Min(x => x.korido);
            
            var eredmeny = autoVersenyLista.Where(x => x.versenyzo == nev);
            if (eredmeny.Count()<1)
            {
                Console.WriteLine("6. Feladat: Nincs ilyen versenyző az állományban!");
                KeresesNevAlapjan();
            }
            else
            {
                int max = int.MaxValue;
                
                foreach (var item in eredmeny)
                {
                    if (item.korido < max)
                    {
                        max = item.korido;
                        minKorido = item;
                    }
                }
                if (minKorido != null)
                {
                    Console.WriteLine("6. Feladat: "+ minKorido.palya +", "+ minKorido.koridoS);
                }
                
            }
            

            
        }
    }
}
