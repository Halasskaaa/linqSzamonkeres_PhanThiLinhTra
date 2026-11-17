using System;
using System.Collections.Generic;
using System.Text;
using ZstdSharp.Unsafe;

namespace linqSzamonkeres_PhanThiLinhTra
{
    internal class Szornyelemzo
    {

        //SzornyAdatbazis db = new SzornyAdatbazis();

        //List<Szorny> szornyek = db.Feltolt();

        private List<Szorny> szornyek;

        public Szornyelemzo(List<Szorny> szornyek)
        {
            this.szornyek = szornyek;
        }

        public int OsszesSzornySzama()
        {
            var eredmeny = szornyek.Count();

            return eredmeny;
        }

        //public IEnumerable<string> VeszelyesSzornyNevek()
        //{
        //    var eredmeny = szornyek.Where(n => n.VeszelyessegiSzint > 5);

        //    foreach (var adat in eredmeny)
        //    {
        //        Console.WriteLine($"Állat neve: {adat.Nev}; Veszélyességi szintje: {adat.VeszelyessegiSzint}");
        //    }
        //}



    }
}