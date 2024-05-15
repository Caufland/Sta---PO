namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadanie 1");
            //Program.Zad1();
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("Zadanie 2");
            //Program.Zad2();
            //Console.WriteLine("");
            //Console.WriteLine("");
            Console.WriteLine("Zadanie 3");
            Program.Zad3();
        }

        static void Zad1()
        {
            Samochod s1 = new Samochod();
            s1.WypiszInfo();
            s1.Marka = "Fiat";
            s1.Model = "126p";
            s1.IloscDrzwi = 2;
            s1.PojemnoscSilnika = 650;
            s1.SrednieSpalanie = 6.0;
            s1.WypiszInfo();
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "KT3763B");
            s2.WypiszInfo();
            double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);
            Samochod.WypiszIloscSamochodw();
            Console.ReadKey();
        }

        static void Zad2()
        {
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0, "KT3763B");
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "KT3763B");
            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);
            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();
            Console.ReadKey();

        }
        static void Zad3()
        {
            var s1 = new Samochod("Fiat", "126p", 2, 650, 6.0, "KT3763B");
            var s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "KT1367C");
            var g1 = new Garaz();
            var o1 = new Osoba("Dominik", "Podraza", "Hodowlana 1424");
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;
            var g2 = new Garaz("ul. Garażowa 2", 2);
            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();
            o1.DodajSamochod("KT3763B");
            o1.DodajSamochod("KT1367C");
            o1.WypiszInfo();
            o1.UsunSamochod("KT3763B");
            o1.WypiszInfo();
            Console.ReadKey();

        }
    }
}