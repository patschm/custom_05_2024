namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        // Gebruik je als je weet hoe vaak je iets moet herhalen.
        for (int i = 0; i < 50; i = i + 2)
        {
            if (i % 4 == 0) continue; // Breekt huidige iteratie af

            Console.WriteLine($"Het getal is {i}");

            //if (i == 6) break; // Breekt huidige loop af
            
        }

        int w = 0;
        // While gebruik je als je niet weet hoe vaak iets moet worden herhaald.
        // Bijv. Een tabel uitlezen. Een bstand uitlezen.
        // Wordt 0 of meer keer uitgevoerd.
        while (w < 10)
        {
            Console.WriteLine($"w is {w++}");
        }


        int x = 0;
        // do-while gebruik je als je niet weet hoe vaak iets moet worden herhaald.
        // User invoer uitlezen
        // Wordt 1 of meer uitgevoerd.
        do
        {
            Console.WriteLine($"x is {x++}");
        }
        while (x < 10);
    }
}
