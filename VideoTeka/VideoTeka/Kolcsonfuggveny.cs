using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoTeka
{
    class Kolcsonfuggveny
    {
        static public void Kivetel(List<Filmek> Videotar, List<Vasarlok> Vasarlok, List<Kolcsonzesek> Kolcsonzes)
        {
            Console.WriteLine("Kérem adja meg melyik filmet szeretné kivenni:");
            string kivkeres = Console.ReadLine();
            foreach (Filmek x in Videotar)
            {
                if (kivkeres == x.Cim)
                {
                    if (x.Holvan.Length == 8)//Holvan=szemszám
                    {
                        Console.WriteLine("A film ki van véve.");
                    }
                    else
                    {
                        Console.WriteLine("Kérem adja meg a kikölcsönző személy nevét:");
                        string keresett = Console.ReadLine();
                        Kolcsonzesek p = new Kolcsonzesek();
                        Console.Clear();
                        foreach (Vasarlok j in Vasarlok)
                        {
                            if (keresett == j.Nev)
                            {
                                x.Holvan = j.Szemigszam;
                                p.Vasarlo = j.Nev;

                            }
                        }
                        Console.WriteLine("Hány napra szeretné kivenni?");
                        int napok = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        p.Film = x.Cim;
                        p.Napokszama = napok;
                        p.Dij = napok * 500;
                        Kolcsonzes.Add(p);
                    }
                }
            }
        }
        static public void Visszahoz(List<Filmek> Videotar, List<Vasarlok> Vasarlok, List<Kolcsonzesek> Kolcsonzes)
        {
            Console.WriteLine("Kérem adja meg melyik filmet hozta vissza:");
            string kivkeres = Console.ReadLine();
            foreach (Kolcsonzesek x in Kolcsonzes)
            {
                if (x.Film == kivkeres)
                {
                    Console.WriteLine("Kérem fizessen {0} Ft-ot.", x.Dij);
                    foreach (Filmek j in Videotar)
                    {
                        if (x.Film == j.Cim)
                        {
                            Console.WriteLine("Kérem adja meg hová raktározza a filmet.");
                            string raktaroz = Console.ReadLine();
                            Console.Clear();
                            j.Holvan = raktaroz;
                            Kolcsonzes.Remove(x);
                        }
                    }                    
                }
                else Console.WriteLine("Nem jól adta meg a film címét.");
                Console.WriteLine("Kilépéshez nyomjon entert.");
                Console.Clear();
            }
        }
    }
}
