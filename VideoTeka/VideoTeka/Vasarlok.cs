using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    class Vasarlok
    {
        protected string nev;
        protected string megye;
        protected string telepules;
        protected string iranyszam;
        protected string cim;
        protected string telefonszam;
        protected string szemigszam;
        public string Nev
        {
            get { return nev; }
            set
            {
                if (value.Length > 20) { throw new Exception("Túl hosszú a vezetéknév!"); }
                if (value.Length < 1) { throw new Exception("Nincsen cím megadva!"); }
                else nev = value;
            }
        }
        public string Megye
        {
            get { return megye; }
            set
            {
                if (value.Length > 22) { throw new Exception("Nincs ilyen hosszú megyénk!"); }
                if (value.Length < 1) { throw new Exception("Nincs megadva megye!"); }
                else megye = value;
            }
        }
        public string Telepules
        {
            get { return telepules; }
            set
            {
                if (value.Length > 16) { throw new Exception("Nincs ilyen hosszú településünk!"); }
                if (value.Length < 1) { throw new Exception("Nincs megadva település!"); }
                else telepules = value;
            }
        }
        public string Iranyszam
        {
            get { return iranyszam; }
            set
            {
                if (value.Length != 4) { throw new Exception("Hibás irányítószám!"); }
                else iranyszam = value;
            }
        }
        public string Cim
        {
            get { return cim; }
            set
            {
                if (value.Length > 30) { throw new Exception("Túl hosszú cím!"); }
                if (value.Length < 1) { throw new Exception("Nincs cím!"); }
                else cim = value;
            }
        }
        public string Telefonszam
        {
            get { return telefonszam; }
            set
            {
                if (value.Length > 11) { throw new Exception("A telefonszám túl hosszú!"); }
                if (10> value.Length) { throw new Exception("A telefonszám túl rövid!"); }
                if (value.Length < 1) { throw new Exception("Nincs megadva telefonszám!"); }
                else telefonszam = value;
            }
        }
        public string Szemigszam
        {
            get { return szemigszam; }
            set
            {
                if (value.Length != 8) { throw new Exception("Nem megfelelő a személyigazolványszám!"); }
                else szemigszam = value;
            }
        }
        public Vasarlok(string pnev, string pmegye, string ptelepules, string piranyszam, string pcim, string ptelefonszam, string pszemigszam)
        {
            nev = pnev;
            megye = pmegye;
            telepules = ptelepules;
            iranyszam = piranyszam;
            cim = pcim;
            telefonszam = ptelefonszam;
            szemigszam = pszemigszam;
        }
        public void Kiir()
        {
            Console.WriteLine("Vezetéknév: " + nev);
            Console.WriteLine("Megye: " + megye);
            Console.WriteLine("Település: " + telepules);
            Console.WriteLine("Irányítószám: " + iranyszam);
            Console.WriteLine("Cím: " + cim);
            Console.WriteLine("Telefonszám: " + telefonszam);
            Console.WriteLine("Személyigazolványszám: " + szemigszam);
        }
    }
}
