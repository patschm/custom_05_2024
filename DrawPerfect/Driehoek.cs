using DrawPerfect;


//using Fig = DrawPerfect.Figuur;

namespace DrawPerfect;

public class Driehoek :  Figuur
{
    private int _basis;
    private int _hoogte;
    public int Basis
    {
        get { return _basis; }
        set
        {
            if (value >= 0)
                _basis = value;
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
    public override double Oppervlakte
    {
        get
        {
            return .5 * Basis * Hoogte;
        }
    }
    public override void Teken()
    {
        Console.WriteLine($"Driehoek met basis {Basis}, hoogte {Hoogte} en kleur {Kleur}");
    }
}
