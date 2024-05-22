using AnimalFarm.Verblijfplaatsen;

namespace AnimalFarm;

public class Zoo
{
    private List<Verblijfplaats> verblijven = new List<Verblijfplaats>();

    public void Assemble(Verblijfplaats verblijfplaats)
    {
        verblijven.Add(verblijfplaats);
    }
    public void Open()
    {
        Console.WriteLine("De dierentuin gaat open");
        foreach(Verblijfplaats verblijfplaats in verblijven)
        {
            verblijfplaats.Rammel();
        }
    }
}
