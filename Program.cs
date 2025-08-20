namespace Tehtava_1._9;

class Program
{
    static void Main(string[] args)
    {
        List<string> kirjat = new List<string>();

        Kirjasto.Kirjastoclass kirjastoclass = new Kirjasto.Kirjastoclass("Nimi", "Kirjoittaja", "Genre");

        Console.WriteLine("Hei, tervetuloa kirjastoon !");

        while (true)
        {
            Console.WriteLine("Jos haluat lisätä kirjoja laita 1");
            Console.WriteLine("Jos haluta poistaa kirjoja laita 2");
            Console.WriteLine("Jos haluat nähdä kaikki kirjat laita 3");
            Console.WriteLine("Jos haluta nähdä kirjat gendren mukaan laita 4");
            Console.WriteLine("Jos haluat löytää kirjan kirjoittajan/kirjan nimellä laita 5");
            Console.WriteLine("Jos haluat lopettaa ohjelman laita 6");

            int vastaus = Convert.ToInt32(Console.ReadLine());
            break;
        }
    }
}
