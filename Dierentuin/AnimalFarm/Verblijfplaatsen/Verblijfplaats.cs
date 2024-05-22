using AnimalFarm.Dieren;

namespace AnimalFarm.Verblijfplaatsen;

public class Verblijfplaats
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
        //if (CanContain(dier))
        //{
            dieren.Add(dier);
       // }
    }

    protected virtual bool CanContain(Dier dier)
    {
        return false;
    }
}
