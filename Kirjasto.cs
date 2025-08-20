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

        public void poistaKirja(List<string> kirjat)
        {
            Console.WriteLine("Anna poistettavan kirjan nimi:");
            string? nimi = Console.ReadLine();

            if (kirjat.RemoveAll(k => k.Contains(nimi)) > 0)
            {
                Console.WriteLine("Kirja poistettu onnistuneesti!");
            }
            else
            {
                Console.WriteLine("Kirjaa ei löytynyt.");
            }
        }

        public void naytaKaikkiKirjat(List<string> kirjat)
        {
            if (kirjat.Count == 0)
            {
                Console.WriteLine("Ei kirjoja kirjastossa.");
            }
            else
            {
                Console.WriteLine("Kaikki kirjat:");
                foreach (string kirja in kirjat)
                {
                    Console.WriteLine(kirja);
                }
            }
        }

        public void kirjatGendrenMukaan(List<string> kirjat)
        {
            Console.WriteLine("Anna genre:");
            string? genre = Console.ReadLine();

            var gendrenKirjat = kirjat.Where(k => k.Contains(genre)).ToList();

            if (gendrenKirjat.Count == 0)
            {
                Console.WriteLine("Ei kirjoja tällä genrellä.");
            }
            else
            {
                Console.WriteLine($"Kirjat genressä {genre}:");
                foreach (string kirja in gendrenKirjat)
                {
                    Console.WriteLine(kirja);
                }
            }
        }

        public void loydaKirja(List<string> kirjat)
        {
            Console.WriteLine("Haluatko etsiä kirjaa kirjoittajan vai nimen perusteella? (1: Kirjoittaja, 2: Nimi)");
            int valinta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna hakusana:");
            string? hakusana = Console.ReadLine();

            var loydetytKirjat = kirjat.Where(k => (valinta == 1 && k.Contains(hakusana)) || (valinta == 2 && k.Contains(hakusana))).ToList();

            if (loydetytKirjat.Count == 0)
            {
                Console.WriteLine("Ei löytynyt kirjoja.");
            }
            else
            {
                Console.WriteLine("Löydetyt kirjat:");
                foreach (string kirja in loydetytKirjat)
                {
                    Console.WriteLine(kirja);
                }
            }
        }

    }
}