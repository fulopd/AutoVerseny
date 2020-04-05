using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerseny.Model
{
    class AutoVersenyModel
    {
        
        public string csapat { get; set; }
        public string versenyzo { get; set; }
        public int eletkor { get; set; }
        public string palya { get; set; }
        public string koridoS { get; set; }
        public int korido { get; set; }
        public int kor { get; set; }

        public AutoVersenyModel(string csapat, string versenyzo, int eletkor, string palya, string korido, int kor)
        {
            this.csapat = csapat;
            this.versenyzo = versenyzo;
            this.eletkor = eletkor;
            this.palya = palya;
            this.koridoS = korido;
            this.kor = kor;
            this.korido = KoridoAtvaltMasodperc(koridoS);
        }

        public AutoVersenyModel()
        {

        }

        private int KoridoAtvaltMasodperc(string korido)
        {
            string[] ido = korido.Split(':');

            int ora = Convert.ToInt32(ido[0]);
            int perc = Convert.ToInt32(ido[1]); ;
            int masodperc = Convert.ToInt32(ido[2]);
            return (ora * 3600) + (perc * 60) + masodperc;
        }
    }
}
