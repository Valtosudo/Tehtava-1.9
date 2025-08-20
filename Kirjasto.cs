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

        public void lisaaKirja(List<string> kirjat)
        {
            Console.WriteLine("Anna kirjan nimi:");
            string? nimi = Console.ReadLine();
            Console.WriteLine("Anna kirjoittajan nimi:");
            string? kirjoittaja = Console.ReadLine();
            Console.WriteLine("Anna kirjan genre:");
            string? genre = Console.ReadLine();

            if (string.IsNullOrEmpty(nimi) || string.IsNullOrEmpty(kirjoittaja) || string.IsNullOrEmpty(genre))
            {
                Console.WriteLine("Kaikki kentät ovat pakollisia. Yritä uudelleen.");
                return;
            }

            Kirjastoclass uusiKirja = new Kirjastoclass(nimi, kirjoittaja, genre);
            kirjat.Add($"{uusiKirja.Nimi} - {uusiKirja.Kirjoittaja} - {uusiKirja.Genre}");
            Console.WriteLine("Kirja lisätty onnistuneesti!");
        }
        
    }
}