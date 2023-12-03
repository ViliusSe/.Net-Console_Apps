internal class Program
{
    // Delegatu iniciavias:
    private delegate string PersonData(string name, string lastname, int age);
    public delegate void NumberChanger(int n);
    private delegate void AnonymPerson(string name, string lastname, int age);
    private delegate void Skaiciavimas(int x, int y);

    static void Main(string[] args)
    {

        /*
                Paprasto delegavimo pavyzdys.
            1. delegatas Persondata sukurimas 6 eiluteje:
            private delegate string PersonData(string name, string lastname, int age);
         */

        //2. Apsirasom funkcijas tinkamas delegatui
        static string ConnectData(string name, string lastname, int age)
        {
            return ($"{name} {lastname} {age}");
        }

        //3. inicijuojam delegata (suteikiam pavadinima + nurodom su kokia f-ja naudoti)
        var connect = new PersonData(ConnectData);

        //4. panaudojam delegata paduodami ji kaip argumenta-funkcija -- WriteLine(argumentas))
        Console.WriteLine(connect("jonas", "jonaitis", 45));


        /*
               Panaudojimas su anonimine funkcija
            1. delegatas NumberChanger sukurtas 7 eiluteje:
            public delegate void NumberChanger(int n);
        */

        //2. Apsirasom funkcijas i kurias delegatas paduodamas kaip argumentas
        static void ExecuteNumberCh(NumberChanger numCh)
        {
            numCh(10);
        }

        //3. panaudojam delegata
        ExecuteNumberCh(delegate (int val)
        {
            Console.WriteLine(val);
        });


        // pirmos pavyzdzio perrasymas su anonimine f-ja.
        static void AnonymPersonToString(AnonymPerson join)
        {
            join("Peter", "Walt", 34);
            join("Andre", "Cofoure", 27);
        }

        AnonymPersonToString(delegate (string name, string lastname, int age)
        {
            Console.WriteLine($"anonimines funkcijos budu panaudojant delegata sukurtas asmuo {name} {lastname} {age}");
        });


        // delegatu naudojimas skirtingiem veiksmams su dviem skaiciais atlikti.
        static void SkaiviavimoRezultatai(Skaiciavimas funkcPavadinimas)
        {
            funkcPavadinimas(3, 4);
        }

        static int Suma(int x, int y)
        {
            return x + y;
        }

        static int Skirtumas(int x, int y)
        {
            return x - y;
        }

        SkaiviavimoRezultatai(delegate (int x, int y)
        {
            Console.WriteLine($"{x}+{y}=" + Suma(x, y));
            Console.WriteLine($"{x}-{y}=" + Skirtumas(x, y));
        });

    }

}