namespace FuncProcs;

class Program
{
    static void Main(string[] args)
    {
        string myname = WhatsYourName();
        ShowWelcomeScreen(myname);
    }

    // Procedure
    static void ShowWelcomeScreen(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    // Function
    static string WhatsYourName()
    {
        do
        {
            Console.WriteLine("What's your name");
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid name");
                continue;
            }
            return name;
        }
        while (true);
    }
}
