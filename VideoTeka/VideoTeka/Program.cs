using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<Filmek> Videotar = new List<Filmek>();
            List<Kolcsonzesek> Kolcsonzes = new List<Kolcsonzesek>();
            List<Vasarlok> Vasarlok = new List<Vasarlok>();
            
            Filmek Transformers = new Filmek("Transformers", 2017, 16, "scifi", "3/3");
            Filmek It = new Filmek("Az", 2017, 18, "horror", "2/3");
            Videotar.Add(Transformers);
            Videotar.Add(It);
            It.Kiir();
            Transformers.Kiir();


            Kolcsonzesek x1 = new Kolcsonzesek(2, 3000, 3000);
            Kolcsonzes.Add(x1);
            x1.Kiir();

            Vasarlok zoli = new Vasarlok("Fehér", "Gergely", "Heves-megye", "Eger", "3300", "Pozsonyi út 18.", "06307194056", "123456AB");
            Vasarlok.Add(zoli);
            zoli.Kiir();

            Console.ReadLine();


        }
    }
}
