namespace Objecten;

public class Student : Persoon
{
    public string? training;

    // Override activeert polymorfisme
     public override void Introduceer()
    {
        //base._leeftijd = 23; // Kan alleen indien _leeftijd protected is
        //base.Introduceer();
        Console.WriteLine($"{voornaam} {achternaam} volgt de training {training}");
    }
}
