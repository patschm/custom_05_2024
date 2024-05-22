namespace AnimalFarm.Dieren;


// Van een sealed classe kan niet meer geerft worden.
public sealed class Zebra : Grazer
{
    public override void MaakGeluid()
    {
        Console.WriteLine("De zebra balkt");
    }
}

// public class Zonki : Zebra
// {

// }
