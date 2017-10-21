using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    class Kolcsonzesek
    {
        protected int napokszama;
        protected int dij;
        protected int kerdijpernap;
        public int Napokszama
        {
            get { return napokszama; }
            set
            {
                if (value > 7) { throw new Exception("Nem lehet több mint egy hétre kikölcsonözni filmet!"); }
                if (value < 1) { throw new Exception("Nincs megadva hány napra kölcsönzik ki!"); }
                else value = napokszama;
            }
        }
        public int Dij
        {
            get { return dij; }
            set { value = dij; }
        }
        public int Kerdijpernap
        {
            get { return kerdijpernap; }
            set { value = kerdijpernap; }
        }
    }
}
