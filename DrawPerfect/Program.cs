namespace DrawPerfect;

class Program
{
    static void Main(string[] args)
    {
        Figuur f1 = new Figuur { FiguurType = Vorm.Rechthoek, Hoogte = 100, Breedte=200};
        Figuur f2 = new Figuur{ FiguurType = Vorm.Cirkel, Straal = 100};
        Figuur f3 = new Figuur {FiguurType = Vorm.Driehoek, Breedte = 200, Hoogte=150};


        f1.Teken();
        f2.Teken();
        f3.Teken();

        Console.WriteLine(f2.Oppervlakte);
        
    }
}
