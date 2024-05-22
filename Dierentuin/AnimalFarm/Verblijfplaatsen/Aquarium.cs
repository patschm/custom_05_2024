using AnimalFarm.Dieren;

namespace AnimalFarm.Verblijfplaatsen;

public class Aquarium: Verblijfplaats
{
    protected override bool CanContain(Dier dier)
    {
        return dier is Vis;
    }
}
