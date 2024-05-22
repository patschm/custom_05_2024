namespace DrawPerfect;

class Program
{
    static void Main(string[] args)
    {
        List<Figuur> figuren = new List<Figuur>();

        DrawPerfect.Rechthoek f1 = new DrawPerfect.Rechthoek { Hoogte = 100, Breedte = 200, Kleur = "Rood" };
        figuren.Add(f1);
        Cirkel f2 = new Cirkel { Straal = 100, Kleur = "Groen" };
        figuren.Add(f2);
        Driehoek f3 = new Driehoek { Basis = 200, Hoogte = 150, Kleur = "Blauw" };
        figuren.Add(f3);
        Vierkant f4 = new Vierkant { Zijde = 150, Kleur = "Geel" };
        figuren.Add(f4);

        // for(int i = 0; i < figuren.Count; i++)
        // {
        //     Figuur f = figuren[i];
        //     f.Teken();
        // }

        foreach (Figuur fig in figuren)
        {
            fig.Teken();
        }

        // f1.Teken();
        // f2.Teken();
        // f3.Teken();
        // f4.Teken();

        Console.WriteLine(f2.Oppervlakte);

    }
}
