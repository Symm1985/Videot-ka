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
            int db = 0;
            foreach (Filmek x in Videotar)
            {
                if (kivkeres != x.Cim)
                {
                    db++;
                    if (db == Videotar.Count-1)
                    {
                        Console.WriteLine("A film nem szerepel a videotárban.");
                        Console.WriteLine("Továbblépéshez nyomjon entert.");
                        Console.ReadLine();
                    }
                }
                if (kivkeres == x.Cim)
                {
                    if (x.Holvan.Length == 8)//Holvan=szemszám
                    {                      
                        Console.WriteLine("A film ki van véve.");
                        Console.WriteLine("Továbblépáshez nyomjon entert.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kérem adja meg a kikölcsönző személy nevét:");
                        string keresett = Console.ReadLine();
                        Kolcsonzesek p = new Kolcsonzesek();
                        //Console.Clear();
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
                        //Console.Clear();
                        p.Film = x.Cim;
                        p.Napokszama = napok;
                        p.Dij = napok * 500;
                        Kolcsonzes.Add(p);
                        break;
                    }
                }
            }
        }
        static public void Visszahoz(List<Filmek> Videotar, List<Vasarlok> Vasarlok, List<Kolcsonzesek> Kolcsonzes)
        {
            bool ne_fusson = false;
            int szemet = -1;
            Console.WriteLine("Kérem adja meg melyik filmet hozta vissza:");
            string kivkeres = Console.ReadLine();
            foreach (Kolcsonzesek x in Kolcsonzes)
            {
                if (x.Film == kivkeres)
                {
                    szemet++;
                    Console.WriteLine("Kérem fizessen {0} Ft-ot.", x.Dij);
                    foreach (Filmek j in Videotar)
                    {
                        if (x.Film == j.Cim)
                        {
                            Console.WriteLine("Kérem adja meg hová raktározza a filmet.");
                            string raktaroz = Console.ReadLine();
                            Console.Clear();
                            j.Holvan = raktaroz;                            
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nem jól adta meg a film címét.");
                    Console.WriteLine("Továbblépéshez nyomjon entert.");
                    Console.ReadLine();
                    ne_fusson = true;
                    break;
                }
            }
            if (ne_fusson = false)
            {
                Kolcsonzes.RemoveAt(szemet);
            }            
            Console.WriteLine("Kilépéshez nyomjon entert.");
            Console.Clear();
        }

    }
}
