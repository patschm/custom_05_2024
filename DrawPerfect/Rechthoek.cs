namespace DrawPerfect;

public class Rechthoek : Figuur
{
    private int _breedte;
    private int _hoogte;
    public virtual int Breedte
    {
        get { return _breedte; }
        set
        {
            if (value >= 0)
                _breedte = value;
        }
    }
    public virtual int Hoogte
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
            return Breedte * Hoogte;
        }
    }
     public override void Teken()
    {
        Console.WriteLine($"Rechthoek met breedte {Breedte}, hoogte {Hoogte} en kleur {Kleur}");
    }
}
