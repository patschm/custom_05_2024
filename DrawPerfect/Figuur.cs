namespace DrawPerfect;

public class Figuur
{
    private int _breedte;
    private int _hoogte;
    private int _straal;

    public Vorm FiguurType;
    public string Kleur;
    public int Breedte
    {
        get { return _breedte; }
        set
        {
            if (value >= 0)
                _breedte = value;
        }
    }
    public int Straal
    {
        get { return _straal; }
        set
        {
            if (value >= 0)
                _straal = value;
        }
    }
    public int Hoogte
    {
        get { return _hoogte; }
        set
        {
            if (value >= 0)
                _hoogte = value;
        }
    }

    public double Oppervlakte
    {
        get
        {
            switch(FiguurType)
            {
                case Vorm.Cirkel:
                    return Math.PI * Math.Pow(Straal, 2);
                case Vorm.Rechthoek:
                case Vorm.Vierkant:
                    return Breedte * Hoogte;
                case Vorm.Driehoek:
                    return .5 * Breedte * Hoogte;
                default:
                    return 0;
            }
        }
    }
    public void Teken()
    {
        Console.Write($"{FiguurType} ");
        switch (FiguurType)
        {
            case Vorm.Rechthoek:
                Console.Write($"met breedte {Breedte} en hoogte {Hoogte}");
                break;
            case Vorm.Vierkant:
                Console.Write($"met breedte {Breedte} en hoogte {Hoogte}");
                break;
            case Vorm.Cirkel:
                Console.Write($"met straal {Straal}");
                break;
            case Vorm.Driehoek:
                Console.Write($"met basis {Breedte} en hoogte {Hoogte}");
                break;
            default:
                Console.Write("met onbekende eigenschappen");
                break;
        }
        Console.WriteLine($" en met kleur {Kleur}");
    }
}
