namespace Kirjasto
{
    class Kirjastoclass
    {
        public string Nimi { get; set; }
        public string Kirjoittaja { get; set; }
        public string Genre { get; set; }

        public Kirjastoclass(string nimi, string kirjoittaja, string genre)
        {
            Nimi = nimi;
            Kirjoittaja = kirjoittaja;
            Genre = genre;
        }
    }
}