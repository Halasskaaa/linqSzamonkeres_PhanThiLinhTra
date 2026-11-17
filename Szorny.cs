using System;
using System.Collections.Generic;
using System.Text;

namespace linqSzamonkeres_PhanThiLinhTra
{
    internal class Szorny
    {
        private int id;
        private string nev;
        private int veszelyessegiSzint;
        private string elohely;
        private string foGyengeseg;
        private string legGyakoribbZsakmany;
        private bool veszelyesE;

        public Szorny(int id, string nev, int veszelyessegiSzint, string elohely, string foGyengeseg, string legGyakoribbZsakmany, bool veszelyesE)
        {
            this.id = id;
            this.nev = nev;
            this.veszelyessegiSzint = veszelyessegiSzint;
            this.elohely = elohely;
            this.foGyengeseg = foGyengeseg;
            this.legGyakoribbZsakmany = legGyakoribbZsakmany;
            this.veszelyesE = veszelyesE;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int VeszelyessegiSzint { get => veszelyessegiSzint; set => veszelyessegiSzint = value; }
        public string Elohely { get => elohely; set => elohely = value; }
        public string FoGyengeseg { get => foGyengeseg; set => foGyengeseg = value; }
        public string LegGyakoribbZsakmany { get => legGyakoribbZsakmany; set => legGyakoribbZsakmany = value; }
        public bool VeszelyesE { get => veszelyesE; set => veszelyesE = value; }
    }
}
