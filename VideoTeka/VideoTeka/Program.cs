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


            Filmek Matrix = new Filmek("Matrix", 1999, 16, "scifi", "3/1");
            Filmek Transformers = new Filmek("Transformers", 2017, 16, "scifi", "3/3");
            Filmek Az = new Filmek("Az", 2017, 18, "horror", "2/3");
            Transformers.Filmhozzaad(Transformers, Videotar);
            Az.Filmhozzaad(Az, Videotar);
            Matrix.Filmhozzaad(Matrix, Videotar);
            //It.Kiir();
            //Transformers.Kiir();
            
            
            Kolcsonzesek x1 = new Kolcsonzesek(2, 3000, 3000);
            Kolcsonzes.Add(x1);
            //x1.Kiir();

            Vasarlok gergely = new Vasarlok("Fehér Gergely", "Heves-megye", "Eger", "3300", "Pozsonyi út 18.", "06307194056", "123456AB");
            Vasarlok.Add(gergely);
            //zoli.Kiir();
            int muvelet1 = 1;
            int muvelet2 = 1;
            do
            {
                Console.WriteLine("Válaszon az alábbi menüpontok közül:");
                Console.WriteLine();
                Console.WriteLine("Filmek: 1");
                Console.WriteLine("Vásárlók: 2");
                Console.WriteLine("Kölcsönzések: 3");
                Console.WriteLine("Kilépés a programból: 0");
                muvelet1 = int.Parse(Console.ReadLine());
                Console.Clear();
                if (muvelet1 == 0)//kilépés a programból
                {
                    Console.WriteLine("A programból való kilépéshez nyomjon egy entert.");
                }
                if (muvelet1 == 1)//filmek
                {
                    do
                    {
                        Console.WriteLine("Kérem válasszon az alábbi menüpontok közül:");
                        Console.WriteLine();
                        Console.WriteLine("Vissza: 0");
                        Console.WriteLine("Film keresése: 1");
                        Console.WriteLine("Film lista kiiratása: 2");
                        muvelet2 = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        if (muvelet2 == 1)//filmkeresés
                        {
                            Console.WriteLine("Kérem adja meg melyik filmet keresi:");
                            string keresett = Console.ReadLine();
                            Console.Clear();
                            bool volt = false;
                            foreach (Filmek x in Videotar)
                            {
                                if (keresett == x.Cim)
                                {
                                    volt = true;
                                    Console.WriteLine("Cím: {0}", x.Cim);
                                    Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                                    Console.WriteLine("Korhatár: {0}", x.Korhatar);
                                    Console.WriteLine("Műfaj: {0}", x.Mufaj);
                                    Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                                    Console.WriteLine("Kilépéshez nyomjon egy entert.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            if (volt == false)
                            {
                                Console.WriteLine("A film nincs meg a videótékában.");
                                Console.WriteLine("Kilépéshez nyomjon egy entert.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        if (muvelet2 == 2)//filmlista kiiratás
                        {
                            foreach (Filmek x in Videotar)
                            {
                                Console.WriteLine("Cím: {0}", x.Cim);
                                Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                                Console.WriteLine("Korhatár: {0}", x.Korhatar);
                                Console.WriteLine("Műfaj: {0}", x.Mufaj);
                                Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                                Console.WriteLine("*****************************************");                                
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    while (muvelet2 != 0);
                }
                if (muvelet1 == 2)//vásárlók
                {

                    do
                    {
                        Console.WriteLine("Kérem válasszon az alábbi menüpontok közül:");
                        Console.WriteLine();
                        Console.WriteLine("Vissza: 0");
                        Console.WriteLine("Vásárló keresése: 1");
                        Console.WriteLine("Vásárlók lista kiiratása: 2");
                        muvelet2 = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        if (muvelet2 == 1)//vásárlókeresés
                        {
                            Console.WriteLine("Kérem adja meg a keresett személy nevét:");
                            string keresett = Console.ReadLine();
                            Console.Clear();
                            bool volt = false;
                            foreach (Vasarlok x in Vasarlok)
                            {
                                if (keresett == x.Nev)
                                {
                                    volt = true;
                                    Console.WriteLine("Név: {0}", x.Nev);
                                    Console.WriteLine("Megye: {0}", x.Megye);
                                    Console.WriteLine("Település: {0}", x.Telepules);
                                    Console.WriteLine("Irányítószám: {0}", x.Iranyszam);
                                    Console.WriteLine("Cím: {0}", x.Cim);
                                    Console.WriteLine("Telefon: {0}", x.Telefonszam);
                                    Console.WriteLine("Személyigazolványszám: {0}", x.Szemigszam);
                                    Console.WriteLine("Kilépéshez nyomjon egy entert.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            if (volt == false)
                            {
                                Console.WriteLine("Nincs ilyen személy az adatbázisban.");
                                Console.WriteLine("Kilépéshez nyomjon egy entert.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        if (muvelet2 == 2)//vásárlóklista kiiratás
                        {
                            foreach (Vasarlok x in Vasarlok)
                            {
                                Console.WriteLine("Név: {0}", x.Nev);
                                Console.WriteLine("Megye: {0}", x.Megye);
                                Console.WriteLine("Település: {0}", x.Telepules);
                                Console.WriteLine("Irányítószám: {0}", x.Iranyszam);
                                Console.WriteLine("Cím: {0}", x.Cim);
                                Console.WriteLine("Telefon: {0}", x.Telefonszam);
                                Console.WriteLine("Személyigazolványszám: {0}", x.Szemigszam);
                                Console.WriteLine("*****************************************");
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    while (muvelet2 != 0);
                }
                if (muvelet1 == 3)//kölcsönzés
                {
                    do
                    {
                        Console.WriteLine("Kérem válasszon az alábbi menüpontok közül:");
                        Console.WriteLine();
                        Console.WriteLine("Vissza: 0");
                        Console.WriteLine("Film kölcsönzés: 1");
                        Console.WriteLine("Film visszavétel: 2");
                        Console.WriteLine("Kikölcsönzött filmek: 3");
                        muvelet2 = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        if (muvelet2 == 1)//filmkeresés
                        {
                            Console.WriteLine("Kérem adja meg melyik filmet keresi:");
                            string keresett = Console.ReadLine();
                            Console.Clear();
                            bool volt = false;
                            foreach (Filmek x in Videotar)
                            {
                                if (keresett == x.Cim)
                                {
                                    volt = true;
                                    Console.WriteLine("Cím: {0}", x.Cim);
                                    Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                                    Console.WriteLine("Korhatár: {0}", x.Korhatar);
                                    Console.WriteLine("Műfaj: {0}", x.Mufaj);
                                    Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                                    Console.WriteLine("Kilépéshez nyomjon egy entert.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            if (volt == false)
                            {
                                Console.WriteLine("A film nincs meg a videótékában.");
                                Console.WriteLine("Kilépéshez nyomjon egy entert.");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        if (muvelet2 == 2)//filmlista kiiratás
                        {
                            foreach (Filmek x in Videotar)
                            {
                                Console.WriteLine("Cím: {0}", x.Cim);
                                Console.WriteLine("Megjelenés: {0}", x.Megjelenesdatuma);
                                Console.WriteLine("Korhatár: {0}", x.Korhatar);
                                Console.WriteLine("Műfaj: {0}", x.Mufaj);
                                Console.WriteLine("Elhelyezkedés: {0}", x.Holvan);
                                Console.WriteLine("*****************************************");
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    while (muvelet2 != 0);
                }
            }
            while (muvelet1 != 0);

            

            Console.ReadLine();


        }
    }
}
