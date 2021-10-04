using System;

namespace rommelzin
{
    class Rommelzin
    {
        static void Main(string[] args)
        {
            Boolean opnieuw = true;
            while (opnieuw)
            {
                string[] vragen = new string[] { "kleur", "eten", "auto", "film", "boek" };
                string[] antwoorden = new string[5];

                Boolean[] vragenGebruikt = new Boolean[] { false, false, false, false, false };
                for (int i = 0; i <= 4; i++)
                {
                    Random rnd = new Random();
                    int temp = rnd.Next(0, 5);
                    while (vragenGebruikt[temp])
                    {
                        temp = rnd.Next(0, 5);
                    }
                    vragenGebruikt[temp] = true;
                    Console.WriteLine("Wat is je favoriete " + vragen[temp] + "?");
                    antwoorden[temp] = Console.ReadLine();
                }
                Console.WriteLine("Je favoriete kleur is " + antwoorden[0] + ". Je eet graag " + antwoorden[1] + ". Je lievelingsfilm is " + antwoorden[2] + ".Je favoriete boek is " + antwoorden[3] + " en je favoriete auto is " + antwoorden[4] + ".");
                Console.WriteLine("Wil je opnieuw? (ja/nee)");
                string antwoordOpnieuw = Console.ReadLine();
                if (antwoordOpnieuw.Equals("ja"))
                {
                    opnieuw = true;
                }
                else if (antwoordOpnieuw.Equals("nee")){
                    opnieuw = false;
                }
            }
        }
    }
}
