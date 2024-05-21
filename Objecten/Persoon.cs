namespace Objecten;

public class Persoon
{
    // Fields
    public int lengteInCM;
    public string voornaam;
    public string achternaam;
    private int _leeftijd = 0;
    public Gender geslacht;

    // Properties
    public int Leeftijd
    {
        get 
        {
            return _leeftijd;
        }
        set
        {
            if (value >= 0 && value < 130)
            {
                _leeftijd = value;
            }

        }
    }

    // Methods
    public void Introduceer()
    {
        Console.WriteLine($"{voornaam} {achternaam} ({Leeftijd}) ({geslacht})");
    }
}
