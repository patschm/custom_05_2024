using AnimalFarm;
using AnimalFarm.Verblijfplaatsen;
using AnimalFarm.Dieren;

namespace AnimalClient;

class Program
{
    static void Main(string[] args)
    {
        Zoo zoo = new Zoo();

        Kooi k = new Kooi();
        zoo.Assemble(k);
        Steppe st = new Steppe();
        zoo.Assemble(st);
        Apenrots rots = new Apenrots();
        zoo.Assemble(rots);
        Aquarium aq = new Aquarium();
        zoo.Assemble(aq);

        Mandril m1 = new Mandril();
        Gorilla g1 = new Gorilla();
        Tijger t1 = new Tijger();
        Leeuw l1 = new Leeuw();
        Sidderaal s1 = new Sidderaal();
        Clownsvis c1 = new Clownsvis();
        Wildebeest w1 = new Wildebeest();
        Zebra z1 = new Zebra();
        Mandril m2 = new Mandril(); 

        // Op safari
        rots.Add(m1);
        rots.Add(m2);
        rots.Add(g1);

        st.Add(w1);
        st.Add(z1);

        aq.Add(s1);
        aq.Add(c1);
        aq.Add(t1);

        k.Add(l1);
        k.Add(t1);

        zoo.Open();

    }
}

// public class Zonki : Zebra
// {

// }
