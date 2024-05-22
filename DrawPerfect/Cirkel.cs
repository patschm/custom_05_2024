namespace DrawPerfect;

public class Cirkel: Figuur
{
    private int _straal;

    public int Straal
    {
        get { return _straal; }
        set
        {
            if (value >= 0)
                _straal = value;
        }
    }

    public override double Oppervlakte
    {
        get
        {
            return Math.PI * Math.Pow(Straal, 2);
        }
    }
    public override void Teken()
    {
        Console.WriteLine($"Cirkel met straal {Straal} en kleur {Kleur}");
    }
}
