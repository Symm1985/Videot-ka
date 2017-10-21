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
        protected string cim;
        protected string telefonszam;
        protected string szemigszam;
        public string Nev
        {
            get { return nev; }
            set
            {
                if (value.Length > 30) { throw new Exception("Túl hosszú a név!"); }
                if (value.Length < 1) { throw new Exception("Nincsen cím megadva!"); }
                else value = nev;
            }
        }
        public string Cim
        {
            get { return cim; }
            set { value = cim; }
        }
        public string Telefonszam
        {
            get { return telefonszam; }
            set
            {
                if (value.Length > 11) { throw new Exception("A telefonszám túl hosszú!"); }
                if (10> value.Length) { throw new Exception("A telefonszám túl rövid!"); }
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
