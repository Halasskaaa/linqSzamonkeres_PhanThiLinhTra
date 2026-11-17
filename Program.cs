namespace linqSzamonkeres_PhanThiLinhTra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis db = new SzornyAdatbazis();

            List<Szorny> szornek = db.Feltolt();

            

        }
    }
}
