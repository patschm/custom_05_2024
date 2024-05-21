namespace Objecten;

class Program
{
    static void Main(string[] args)
    {
        Persoon p1 = new Persoon{
            voornaam = "Jan",
            achternaam = "Pieters",
            Leeftijd = 42,
            geslacht = Gender.Man
        };

        Persoon p2 = new Persoon();
        p2.voornaam = "Marieke";
        p2.achternaam = "Hanssen";
        p2.Leeftijd = 33;
        p2.geslacht = Gender.Vrouw;


        p1.Introduceer();

        p2.Introduceer();
    }
}

