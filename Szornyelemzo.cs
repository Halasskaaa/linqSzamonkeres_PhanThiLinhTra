using System;
using System.Collections.Generic;
using System.Text;
using ZstdSharp.Unsafe;

namespace linqSzamonkeres_PhanThiLinhTra
{
    internal class Szornyelemzo
    {

        SzornyAdatbazis db = new SzornyAdatbazis();

        List<Szorny> szornyek = db.Feltolt();


        public int OsszesSzornySzama()
        {
            var eredmeny = szornyek
                .Count();

            return eredmeny;
        }



    }
}
