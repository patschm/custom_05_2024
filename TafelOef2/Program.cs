namespace TafelOef2;

class Program
{
    static void Main(string[] args)
    {
        int tafel;
        do
        {
            Console.WriteLine("Welke tafel? (getal tussen 1 en 100)");
            string stafel = Console.ReadLine();

            if (!int.TryParse(stafel, out tafel))
            {
                Console.WriteLine("Ongeldige invoer");
            }
            if (tafel <= 0 || tafel > 100)
            {
                Console.WriteLine("Geen geldige tafel");
            }
            else
            {
                break;
            }
        }
        while (true);


        Console.WriteLine($"De tafel van {tafel}");
        for (int teller = 1; teller <= 10; teller++)
        {
            Console.WriteLine($"{teller} x {tafel} = {teller * tafel}");
        }
    }
}

