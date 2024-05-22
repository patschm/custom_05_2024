namespace DrawPerfect;

public class Vierkant : Rechthoek
{
    private int _zijde;
    public override int Hoogte
    {
        set
        {
            _zijde = value;
        }
        get { return _zijde; }
    }
    public override int Breedte
    {
       set
       {
            _zijde = value;
       }
       get { return _zijde; }
    }
    public int Zijde
    {
        get { return _zijde; }
        set { if (value >= 0) _zijde = value; }
    } 
     public override void Teken()
    {
        Console.WriteLine($"Vierkant met zijde {Zijde} en kleur {Kleur}");
    }    
}
