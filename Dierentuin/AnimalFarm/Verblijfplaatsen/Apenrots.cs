using AnimalFarm.Dieren;

namespace AnimalFarm.Verblijfplaatsen;

public class Apenrots : Verblijfplaats
{
    protected override bool CanContain(Dier dier)
    {
        return dier is Aap;
    }
}
