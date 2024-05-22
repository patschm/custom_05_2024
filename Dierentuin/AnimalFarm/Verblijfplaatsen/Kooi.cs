using AnimalFarm.Dieren;
namespace AnimalFarm.Verblijfplaatsen;

public class Kooi: Verblijfplaats
{
    protected override bool CanContain(Dier dier)
    {
        return dier is Kat;
    }
}
