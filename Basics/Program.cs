namespace Basics;

class Program
{
    // Main entry point
    static void Main(string[] args)  // args is command-line arguments
    {
        // Big bang

        // long: 64 bite ()
        // int: 32 bits (-2.3B - 2.3B
        // short: 16 bits (-32000 - 32000))
        // byte: 8 bits (0, 255)

        // float: 43 bits
        // double: 64 bits
        // decimal: 128 bits

        // short tmp = 32000;

        // ***!!!!!!!!
        // TypeNaam variabeleNaam;
        // ***!!!!!!!!
        int age = 42;  // 42 is een literal

        char letter = 'x';  // 'x' is een literal
        string name = "Patrick";

        // Accolades bepalen de scope
        {
            DateTime nu = DateTime.Now;
        }
        Console.WriteLine(nu);

        Console.WriteLine(age);
        //Console.WriteLine(args?[0]);
        //Console.WriteLine(args?[1]);
        Console.WriteLine("Hello, World!");


        // Big Crunch
    }
}
