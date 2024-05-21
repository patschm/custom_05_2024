namespace Operators;

class Program
{
    static void Main(string[] args)
    {
       // Rekenkundige operatoren
       // +, -, *, %, /
        int a = 10;
        int b = 20;

        // = is een toekennings oprator

        int c = a + b * 3;

        // ++, -- zijn unaire operatoren. Ze werken op een operand
        // a = a + 1;
        // () is ook een operator: De invokation operator.
        Console.WriteLine(a++);
        Console.WriteLine(a);

        a = a + 2;
        // Combined operators
        Console.WriteLine(a+=5);
        a += 2;

        

    }
}
