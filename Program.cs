namespace linqSzamonkeres_PhanThiLinhTra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis db = new SzornyAdatbazis();

            List<Szorny> szornyek = db.Feltolt();

            //var eredmeny = szornyek
            //    .Count();

            var eredmeny = szornyek.Where(n => n.VeszelyessegiSzint > 5);

            foreach (var adat in eredmeny)
            {
                Console.WriteLine($"Állat neve: {adat.Nev}; Veszélyességi szintje: {adat.VeszelyessegiSzint}");
            }


        }
    }
}