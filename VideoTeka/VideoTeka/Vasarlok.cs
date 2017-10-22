using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    class Vasarlok
    {
        protected int id;
        protected string veznev;
        protected string kernev;
        protected string megye;
        protected string telepules;
        protected string iranyszam;
        protected string cim;
        protected string telefonszam;
        protected string szemigszam;
        protected int ID
        {
            get { return id; }
        }
        public string Veznev
        {
            get { return veznev; }
            set
            {
                if (value.Length > 20) { throw new Exception("Túl hosszú a vezetéknév!"); }
                if (value.Length < 1) { throw new Exception("Nincsen cím megadva!"); }
                else value = veznev;
            }
        }
        public string Kernev
        {
            get { return kernev; }
            set
            {
                if (value.Length > 20) { throw new Exception("Túl hosszú a keresztnév!"); }
                if (value.Length < 1) { throw new Exception("Nincsen cím megadva!"); }
                else value = kernev;
            }
        }
        public string Megye
        {
            get { return megye; }
            set
            {
                if (value.Length > 22) { throw new Exception("Nincs ilyen hosszú megyénk!"); }
                if (value.Length < 1) { throw new Exception("Nincs megadva megye!"); }
                else value = megye;
            }
        }
        public string Telepules
        {
            get { return telepules; }
            set
            {
                if (value.Length > 16) { throw new Exception("Nincs ilyen hosszú településünk!"); }
                if (value.Length < 1) { throw new Exception("Nincs megadva település!"); }
                else value = telepules;
            }
        }
        public string Iranyszam
        {
            get { return iranyszam; }
            set
            {
                if (value.Length != 4) { throw new Exception("Hibás irányítószám!"); }
                else value = iranyszam;
            }
        }
        public string Cim
        {
            get { return cim; }
            set
            {
                if (value.Length > 30) { throw new Exception("Túl hosszú cím!"); }
                if (value.Length < 1) { throw new Exception("Nincs cím!"); }
                else value = cim;
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
                else value = telefonszam;
            }
        }
        public string Szemigszam
        {
            get { return szemigszam; }
            set
            {
                if (value.Length != 8) { throw new Exception("Nem megfelelő a személyigazolványszám!"); }
                else value = szemigszam;
            }
        }
    }
}
