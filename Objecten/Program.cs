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

        CallIntroduce(p1);
        CallIntroduce(p2);

        //p1.Introduceer();

        //p2.Introduceer();
        
        Student s1 = new Student {
            voornaam = "Rene",
            achternaam = "Maters",
            Leeftijd = 22,
            geslacht = Gender.NonBinair,
            training = "OOPCS"
        };
        s1.Introduceer();
        CallIntroduce(s1);

    }

    static void CallIntroduce(Persoon p)
    {
        p.Introduceer();
    }
}

