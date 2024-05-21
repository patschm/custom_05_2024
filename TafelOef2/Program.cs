namespace TafelOef2;

class Program
{
    static void Main(string[] args)
    {
        int tafel = AskForTable();
        ShowTable(tafel);
    }


    /// <summary>
    /// Deze routine laat de tafel van iets zien.
    /// </summary>
    /// <param name="table">De tafel</param>
    static void ShowTable(int table)
    {
        Console.WriteLine($"De tafel van {table}");
        for (int teller = 1; teller <= 10; teller++)
        {
            Console.WriteLine($"{teller} x {table} = {teller * table}");
        }
    }

    /// <summary>
    /// Vraag de gebruiker om een getal tussen 0 en 100
    /// <code>
    ///    int nr = AskForTable();
    /// </code>
    /// </summary>
    /// <returns>het opgegeven getal (tussen 0 en 100)</returns>
    static int AskForTable()
    {
        do
        {
            Console.WriteLine("Welke tafel? (getal tussen 1 en 100)");
            string? stafel = Console.ReadLine();
            int tafel;
            if (!int.TryParse(stafel, out tafel))
            {
                Console.WriteLine("Ongeldige invoer");
                continue;
            }
            if (tafel <= 0 || tafel > 100)
            {
                Console.WriteLine($"Geen geldige tafel ({tafel}). Waarde moet tussen 0 en 100 liggen.");
                continue;
            }
            return tafel;
        }
        while (true);
    }
}

