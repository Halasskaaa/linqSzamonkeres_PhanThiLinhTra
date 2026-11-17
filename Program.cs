namespace linqSzamonkeres_PhanThiLinhTra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis db = new SzornyAdatbazis();

            List<Szorny> szornyek = db.Feltolt();

            // Szörnyek száma
            var eredmeny1 = szornyek
                .Count();

            Console.WriteLine($"Összes szörny száma: {eredmeny1}");

            Console.WriteLine();

            // Veszélyes szörnyek kiiratása
            var eredmeny2 = szornyek.Where(n => n.VeszelyessegiSzint > 5);

            foreach (var adat in eredmeny2)
            {
                Console.WriteLine($"Szörny neve: {adat.Nev}; Veszélyességi szintje: {adat.VeszelyessegiSzint}");
            }

            Console.WriteLine();

            // Egyedi élőhelyek kiiratása

            var eredmeny3 = szornyek.Select(n => n.Elohely);

            foreach (var adat in eredmeny3)
            {
                Console.WriteLine($"Élőhelyek: {eredmeny3}");
            }

            Console.WriteLine();

            // Átlagos veszélyességi szint

            var eredmeny4 = szornyek.Average(n => n.VeszelyessegiSzint);

            Console.WriteLine($"Szörnyek átlagos veszélyességi szintje: {eredmeny4}");

            Console.WriteLine();

            // Legveszélyesebb szörnyek

            var eredmeny5 = szornyek.Where(n => n.VeszelyessegiSzint == 10);

            Console.WriteLine("Legveszélyeseb szörnyek: ");

            foreach (var adat in eredmeny5)
            {
                Console.WriteLine(adat.Nev);
            }

            Console.WriteLine();

            // Mocsári szörnyek

            var eredmeny6 = szornyek.Where(n => n.Elohely == "Fekete Mocsár");

            foreach (var adat in eredmeny6)
            {
                Console.WriteLine(adat.Nev);
            }

            Console.WriteLine();

            // Tűz gyengeség

            var eredmeny7 = szornyek.Where(n => n.FoGyengeseg == "Tűz");

            foreach (var adat in eredmeny7)
            {
                Console.WriteLine(adat.Nev);
            }

            Console.WriteLine();

            // Szörnyek száma élőhyelyenként

            //var eredmeny8 = szornyek.GroupBy(n => n.Elohely).Select(n =>
            //{
            //    Elohely = n.Key,
            //    Count = n.Count()
            //});

            //foreach (var adat in eredmeny8)
            //{
            //    Console.WriteLine(eredmeny8);
            //}
        }
    }
}