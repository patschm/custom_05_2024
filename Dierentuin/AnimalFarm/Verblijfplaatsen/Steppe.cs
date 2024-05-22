using AnimalFarm.Dieren;
namespace AnimalFarm.Verblijfplaatsen;

public class Steppe : Verblijfplaats
{
    protected override bool CanContain(Dier dier)
    {
        return dier is Grazer;
    }
}
