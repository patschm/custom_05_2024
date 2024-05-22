using AnimalFarm.Dieren;

namespace AnimalFarm.Verblijfplaatsen;

public abstract class Verblijfplaats
{
    private List<Dier> dieren = new List<Dier>();

    public void Rammel()
    {
        foreach (Dier d in dieren)
        {
            d.MaakGeluid();
        }
    }
    public void Add(Dier dier)
    {
        if (CanContain(dier))
        {
            dieren.Add(dier);
        }
        else
        {
            Console.WriteLine($"{dier.GetType().Name} kan niet in dit {GetType().Name}");
        }
    }

    // Bij abstract _MOET_ een afgeleide class overriden.
    // Gevolg is wel dat de hele class abstract wordt.
    protected abstract bool CanContain(Dier dier);

    // Bij virtual _MAG_ een afgeleide class overriden, maar _HOEFT_ dit niet te doen.
    //protected virtual bool CanContain(Dier dier);
    // {
    //     return false;
    // }
}
