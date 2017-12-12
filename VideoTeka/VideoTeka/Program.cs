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

            Filmek Matrix = new Filmek("Matrix", 1999, 16, "scifi", "1 polc");
            Filmek Transformers = new Filmek("Transformers", 2017, 16, "scifi", "1 polc");
            Filmek Az = new Filmek("Az", 2017, 18, "horror", "2 polc");
            Filmek Thor = new Filmek("Thor", 2016, 16, "scifi", "1 polc");
            Filmek StarTrek_Csillagösvény = new Filmek("StarTrek Csillagösvény ", 1979, 12, "scifi", "1 polc");
            Filmek StarTrek_Khan_haragja = new Filmek("StarTrek Khan haragja", 1982, 12, "scifi", "1 polc");
            Filmek StarTrek_Spock_nyomában = new Filmek("StarTrek Spock nyomában", 1984, 12, "scifi", "1 polc");
            Filmek StarTrek_A_hazatérés = new Filmek("StarTrek A hazatérés", 1986, 12, "scifi", "1 polc");
            Filmek StarTrek_A_végső_határ = new Filmek("StarTrek A végső határ", 1989, 12, "scifi", "2/3");
            Filmek StarTrek_A_nem_ismert_tartomány = new Filmek("StarTrek A nem ismert tartomány", 1991, 12, "scifi", "1 polc");
            Filmek StarTrek_Nemzedékek = new Filmek("StarTrek Nemzedékek", 1994, 12, "scifi", "2/3");
            Filmek StarTrek_Kapcsolatfelvétel = new Filmek("StarTrek Kapcsolatfelvétgel", 1996, 12, "scifi", "1 polc");
            Filmek StarTrek_Űrlázadás = new Filmek("StarTrek Űrlázadás", 1998, 12, "scifi", "1 polc");
            Filmek StarTrek_Nemesis = new Filmek("StarTrek Nemesis", 2002, 12, "scifi", "1 polc");
            Filmek StarTrek = new Filmek("StarTrek A végső határ", 2009, 16, "scifi", "1 polc");
            Filmek StarTrek_Sötétségben = new Filmek("StarTrek Sötétségben", 2013, 16, "scifi", "1 polc");
            Filmek StarTrek_Mindenen_túl = new Filmek("StarTrek Mindenen túl", 2016, 16, "scifi", "1 polc");
            Filmek Star_Wars_Egy_új_remény = new Filmek("StarWars Egy új remény", 1977, 12, "scifi", "1 polc");
            Filmek Star_Wars_A_birodalom_visszavág = new Filmek("Star Wars A birodalom visszavág", 1980, 12, "scifi", "1 polc");
            Filmek Star_Wars_A_jedi_visszatér = new Filmek("Star Wars A jedi visszatér", 1983, 12, "scifi", "1 polc");
            Filmek Star_Wars_Baljós_árnyak = new Filmek("Star Wars Baljós_árnyak", 1999, 12, "scifi", "1 polc");
            Filmek Star_Wars_A_klónok_támadása = new Filmek("Star Wars A klónok támadása", 2002, 12, "scifi", "1 polc");
            Filmek Star_Wars_A_Sithek_bosszúja = new Filmek("Star Wars A Sithek bosszúja", 2005, 12, "scifi", "1 polc");
            Filmek Armageddon = new Filmek("Armageddon", 1989, 16, "katasztrófa", "3 polc");
            Filmek A_függetlenség_napja = new Filmek("A_függetlenség napja", 1996, 16, "katasztrófa", "3 polc");
            Filmek Urvihar = new Filmek("űrvihar", 2017, 16, "katasztrófa", "4 polc");
            Filmek Thor3 = new Filmek("Thor Ragnarök", 2017, 12, "fantasztikus", "4 polc");
            Filmek Furesz_ujra_jatakban = new Filmek("Fűrész újra játékban", 2017, 18, "horror", "5 polc");
            Filmek Kincsem = new Filmek("Kincsem", 2017, 12, "magyar", "4 polc");
            Filmek GYilkossag_az_Orient_expressen = new Filmek("Gyilkosság az orient expresszen", 2017, 12, "krimi", "3 polc");
            Filmek Tűzgyűrű = new Filmek("Tűzgyűrű", 2013, 16, "akció", "2 polc");
            Filmek Titanic = new Filmek("Titanic", 1997, 16, "katasztrófa", "4 polc");
            Filmek Transformers_ = new Filmek("Transformersz", 2007, 12, "scifi-akció", "2 polc");
            
            Transformers.Filmhozzaad(Videotar, Transformers);
            Az.Filmhozzaad(Videotar, Az);
            Matrix.Filmhozzaad(Videotar, Matrix);
            Thor.Filmhozzaad(Videotar, Thor);
            StarTrek_Csillagösvény.Filmhozzaad(Videotar, StarTrek_Csillagösvény);
            StarTrek_Khan_haragja.Filmhozzaad(Videotar, StarTrek_Khan_haragja);
            StarTrek_Spock_nyomában.Filmhozzaad(Videotar, StarTrek_Spock_nyomában);
            StarTrek_A_hazatérés.Filmhozzaad(Videotar, StarTrek_A_hazatérés);
            StarTrek_A_végső_határ.Filmhozzaad(Videotar, StarTrek_A_végső_határ);
            StarTrek_A_nem_ismert_tartomány.Filmhozzaad(Videotar, StarTrek_A_nem_ismert_tartomány);
            StarTrek_Nemzedékek.Filmhozzaad(Videotar, StarTrek_Nemzedékek);
            StarTrek_Kapcsolatfelvétel.Filmhozzaad(Videotar, StarTrek_Kapcsolatfelvétel);
            StarTrek_Űrlázadás.Filmhozzaad(Videotar, StarTrek_Űrlázadás);
            StarTrek_Nemesis.Filmhozzaad(Videotar, StarTrek_Nemesis);
            StarTrek.Filmhozzaad(Videotar, StarTrek);
            StarTrek_Sötétségben.Filmhozzaad(Videotar, StarTrek_Sötétségben);
            StarTrek_Mindenen_túl.Filmhozzaad(Videotar, StarTrek_Mindenen_túl);
            Star_Wars_Egy_új_remény.Filmhozzaad(Videotar, Star_Wars_Egy_új_remény);
            Star_Wars_A_birodalom_visszavág.Filmhozzaad(Videotar, Star_Wars_A_birodalom_visszavág);
            Star_Wars_A_jedi_visszatér.Filmhozzaad(Videotar, Star_Wars_A_jedi_visszatér);
            Star_Wars_Baljós_árnyak.Filmhozzaad(Videotar, Star_Wars_Baljós_árnyak);
            Star_Wars_A_klónok_támadása.Filmhozzaad(Videotar, Star_Wars_A_klónok_támadása);
            Star_Wars_A_Sithek_bosszúja.Filmhozzaad(Videotar, Star_Wars_A_Sithek_bosszúja);
            Armageddon.Filmhozzaad(Videotar, Armageddon);
            A_függetlenség_napja.Filmhozzaad(Videotar, A_függetlenség_napja);
            Urvihar.Filmhozzaad(Videotar, Urvihar);
            Thor3.Filmhozzaad(Videotar, Thor3);
            Furesz_ujra_jatakban.Filmhozzaad(Videotar, Furesz_ujra_jatakban);
            Kincsem.Filmhozzaad(Videotar, Kincsem);
            GYilkossag_az_Orient_expressen.Filmhozzaad(Videotar, GYilkossag_az_Orient_expressen);
            Tűzgyűrű.Filmhozzaad(Videotar, Tűzgyűrű);
            Titanic.Filmhozzaad(Videotar, Titanic);
            Transformers_.Filmhozzaad(Videotar, Transformers_);
        

            //It.Kiir();
            //Transformers.Kiir();
            
            
            //Kolcsonzesek x1 = new Kolcsonzesek(2, 3000, 3000);
            //Kolcsonzes.Add(x1);
            //x1.Kiir();
       
            Vasarlok gergely = new Vasarlok("Fehér Gergely", "Heves-megye", "Eger", "3300", "Pozsonyi út 18.", "06307194056", "123456AB");
            Vasarlok.Add(gergely);            
            Vasarlok dani = new Vasarlok("Kovács Dániel", "Pest megye", "Budapest", "3300", "Borsó utca.", "06302165956", "123456BC");
            Vasarlok.Add(dani);
            Vasarlok niki = new Vasarlok("Jónás Nikolett", "Heves-megye", "Eger", "3300", "Pozsonyi út 18.", "06307194056", "123456CD");
            Vasarlok.Add(niki);
            Vasarlok adrienn = new Vasarlok("Molnár Adrienn", "Heves-megye", "Eger", "3300", "Pozsonyi út 18.", "06307194056", "123456DE");
            Vasarlok.Add(adrienn);
            Vasarlok jacint = new Vasarlok("Fehér Jácint", "Heves-megye", "Eger", "3300", "Kiskanda út 4.", "06305419033", "639214JK");
            Vasarlok.Add(jacint);
            Vasarlok zsuzsa = new Vasarlok("Katona Zsuzsa", "Heves-megye","Eger", "3300", "Igli út 19.", "06201234567", "321456AB");
            Vasarlok.Add(zsuzsa);
            Vasarlok balaz = new Vasarlok("Kiss Balázs", "Heves-megye", "Eger", "3300", "Széna-tér", "06205438921", "547632VB");
            Vasarlok.Add(balaz);

            //vásárlók adatai még módosítva lesznek!
            //zoli.Kiir();
            string muvelet1;
            string muvelet2;
            do
            {
                Console.WriteLine("Válaszon az alábbi menüpontok közül:");
                Console.WriteLine();
                Console.WriteLine("Filmek: 1");
                Console.WriteLine("Vásárlók: 2");
                Console.WriteLine("Kölcsönzések: 3");
                Console.WriteLine("Filmek böngészése: 4");
                Console.WriteLine("Kilépés a programból: 0");
                muvelet1 = Console.ReadLine();
                Console.Clear();
                if (muvelet1 == "0")//kilépés a programból
                {
                    Console.WriteLine("A programból való kilépéshez nyomjon egy entert.");
                }
                if (muvelet1 == "1")//filmek
                {
                    do
                    {
                        Console.WriteLine("Kérem válasszon az alábbi menüpontok közül:");
                        Console.WriteLine();
                        Console.WriteLine("Vissza: 0");
                        Console.WriteLine("Film keresése: 1");
                        Console.WriteLine("Film lista kiiratása: 2");
                        muvelet2 = Console.ReadLine();
                        Console.Clear();
                        if (muvelet2 == "1")//filmkeresés
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
                        if (muvelet2 == "2")//filmlista kiiratás
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
                        else
                        {
                            continue;
                        }
                    }
                    while (muvelet2 != "0");
                }
                if (muvelet1 == "2")//vásárlók
                {

                    do
                    {
                        Console.WriteLine("Kérem válasszon az alábbi menüpontok közül:");
                        Console.WriteLine();
                        Console.WriteLine("Vissza: 0");
                        Console.WriteLine("Vásárló keresése: 1");
                        Console.WriteLine("Vásárlók lista kiiratása: 2");
                        muvelet2 = Console.ReadLine();
                        Console.Clear();
                        if (muvelet2 == "1")//vásárlókeresés
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
                        if (muvelet2 == "2")//vásárlóklista kiiratás
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
                        else
                        {
                            continue;
                        }
                    }
                    while (muvelet2 != "0");
                }
                if (muvelet1 == "3")//kölcsönzés
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Kérem válasszon az alábbi menüpontok közül:");
                        Console.WriteLine();
                        Console.WriteLine("Vissza: 0");
                        Console.WriteLine("Film kölcsönzés: 1");
                        Console.WriteLine("Film visszavétel: 2");
                        Console.WriteLine("Kikölcsönzött filmek: 3");
                        muvelet2 = Console.ReadLine();
                        Console.Clear();
                        if (muvelet2 == "1")//filmkölcsönzés
                        {
                            Kolcsonfuggveny.Kivetel(Videotar, Vasarlok, Kolcsonzes);
                        }
                        if (muvelet2 == "2")//filmvisszavitel
                        {
                            if (Kolcsonzes.Count == 0)
                            {
                                Console.WriteLine("Nincs kikölcsönzött film.");
                                Console.WriteLine("A továbblépéshez kérem nyomjon entert.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Kolcsonfuggveny.Visszahoz(Videotar, Vasarlok, Kolcsonzes);
                            }

                        }
                        if (muvelet2 == "3")//kivett filmek
                        {
                            foreach (Kolcsonzesek x in Kolcsonzes)
                            {
                                Console.WriteLine("Cím: {0}", x.Film);
                                Console.WriteLine("Kivették: {0} {1} napra",x.Vasarlo ,x.Napokszama);
                                Console.WriteLine("*****************************************");
                            }
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            continue;
                        }
                    }
                    while (muvelet2 != "0");
                }
                if (muvelet1 == "4")//filmböngészés
                {
                    do
                    {
                        Console.WriteLine("Kérem válasszon az alábbi menüpontok közül:");
                        Console.WriteLine();
                        Console.WriteLine("Vissza: 0");
                        Console.WriteLine("Film keresés cím szerint: 1");
                        Console.WriteLine("Film keresés műfaj szerint: 2");
                        Console.WriteLine("Film keresés korhatár szerint: 3");                      
                        muvelet2 = Console.ReadLine();
                        Console.Clear();
                        if (muvelet2 == "1")//címkeres
                        {
                            Bongesz.Cimkeres(Videotar);
                        }
                        if (muvelet2 == "2")//műfajkeres
                        {
                            Bongesz.Mufajkeres(Videotar);
                        }
                        if (muvelet2 == "3")//korhatár keres
                        {
                            Bongesz.Korahatarkeres(Videotar);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    while (muvelet2 != "0");
                }
                else
                {
                    continue;
                }
            }
            while (muvelet1 != "0");
            
            

            Console.ReadLine();


        }
    }
}
