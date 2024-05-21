namespace Conditions;

class Program
{
    static void Main(string[] args)
    {
        int age = 10;

        // if gebruik je voornamelijk voor range checks of een concrete waarde.
        if (age >= 18)
        {
            Console.WriteLine("Jij mag naar binnen");
        }
        else
        {
            Console.WriteLine("Te jong. Doei!");
        }


        if (age == 10)
        {

        }
        else if (age == 11)
        {

        }
        else if (age == 12)
        {

        }
        else
        {

        }
        //

        switch (age)
        {
            // Fall-through
            case 9:
            case 10:
                Console.WriteLine("Negen of Tien");
                break;
            case 11:
                Console.WriteLine("Elf");
                break;
            case 12:
                Console.WriteLine("Twaalf");
                break;
            default:
                Console.WriteLine("Anders");
                break;
        }
    }
}
