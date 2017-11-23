using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    class Bongesz
    {
        static public void Cimkeres(List<Filmek> Videotar)
        {
            Console.WriteLine("Kérem adja meg melyik filmet keresi:");
            string filmkeres = Console.ReadLine();
            bool megvan = false;
            Console.Clear();
            foreach (Filmek x in Videotar)
            {
                if (x.Cim == filmkeres)
                {
                    Console.WriteLine("Cím: {0}", x.Cim);
                    Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                    Console.WriteLine("Korhatár: {0}", x.Korhatar);
                    Console.WriteLine("Műfaj: {0}", x.Mufaj);
                    Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                    megvan = true;
                }
            }
            if (megvan == false)
            {
                Console.WriteLine("A film nem található a videótárban.");
            }
        }
        static public void Mufajkeres(List<Filmek> Videotar)
        {
            Console.WriteLine("Kérem adja meg milyen műfajú filmet keres:");
            string mufajkeres = Console.ReadLine();
            bool megvan = false;
            Console.Clear();
            foreach (Filmek x in Videotar)
            {
                if (x.Mufaj == mufajkeres)
                {
                    Console.WriteLine("Cím: {0}", x.Cim);
                    Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                    Console.WriteLine("Korhatár: {0}", x.Korhatar);
                    Console.WriteLine("Műfaj: {0}", x.Mufaj);
                    Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                    Console.WriteLine("*****************************************");
                    megvan = true;
                }
            }
            if (megvan == false)
            {
                Console.WriteLine("Ilyen műfajú film nem található a videótárban.");
            }
        }
        static public void Korahatarkeres(List<Filmek> Videotar)
        {
            Console.WriteLine("Kérem adja meg a film korhatárát:");
            int korhatarkeres = Convert.ToInt32(Console.ReadLine());
            bool megvan = false;
            Console.Clear();
            foreach (Filmek x in Videotar)
            {
                if (x.Korhatar <= korhatarkeres)
                {
                    Console.WriteLine("Cím: {0}", x.Cim);
                    Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                    Console.WriteLine("Korhatár: {0}", x.Korhatar);
                    Console.WriteLine("Műfaj: {0}", x.Mufaj);
                    Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                    Console.WriteLine("*****************************************");
                    megvan = true;
                }
            }
            if (megvan == false)
            {
                Console.WriteLine("Ilyen korhatárú film nem található a vidótárban.");
            }
        }
    }
}
