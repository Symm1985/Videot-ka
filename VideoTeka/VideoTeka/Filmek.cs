using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    class Filmek
    {
        protected string cim;
        protected int megjelenesdatuma;
        protected int korhatar;
        protected string mufaj;
        protected string holvan;
        public string Cim
        {
            get { return cim; }
            set
            {
                if (value.Length > 30) { throw new Exception("Nem lehet ilyen hosszú Film cím!"); }
                if (value.Length < 1) { throw new Exception("Nincsen film cím megadva!"); }
                else cim = value;
            }
        }
        public int Megjelenesdatuma
        {
            get { return megjelenesdatuma; }
            set
            {
                if (value > 2017) { throw new Exception("Még nem jelent meg a Film!"); }
                if (value < 1) { throw new Exception("Nincs megadva Filmcím!"); }            }
        }
        public int Korhatar
        {
            get { return korhatar; }
        }
        public string Mufaj
        {
            get { return mufaj; }
            set
            {
                if (value.Length > 20) { throw new Exception("Túl hosszú műfaj!"); }
                if (value.Length < 1) { throw new Exception("Nincs műfaj megadva!"); }
                else mufaj = value;
            }
        }
        public string Holvan
        {
            get { return holvan; }
            set { holvan = value; }
        }
        public Filmek(string pcim, int pmegjelenesdatuma, int pkorhatar, string pmufaj, string pholvan)
        {
            cim = pcim;
            megjelenesdatuma = pmegjelenesdatuma;
            korhatar = pkorhatar;
            mufaj = pmufaj;
            holvan = pholvan;
        }
        public void Kiir()
        {
            Console.WriteLine("Cím: " +cim);
            Console.WriteLine("Megjelenés: " +megjelenesdatuma);
            Console.WriteLine("Korhatár: " +korhatar);
            Console.WriteLine("Műfaj: " +mufaj);
            Console.WriteLine("Elhelyezkedés: " +holvan);
        }
    }
}
