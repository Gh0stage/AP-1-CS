using System;
using System.Timers;

namespace visitekaartje
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vragen = new string[]
            {
                "Wat is je voornaam",
                "Wat is je achternaam",
                "Waar woon je",
                "Wat is je hobby",
                "Waarom koos je voor deze opleiding",
                "Waarom koos je voor AP"
            };
            string[] gegevens = new string[]
            {
                "voornaam",
                "achternaam",
                "adres",
                "hobby",
                "interesse in opleiding",
                "interesse in school"
            };
            string[] antwoorden = new string[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(vragen[i] + "?");
                antwoorden[i] = Console.ReadLine();
                Console.WriteLine("");
            }
            Console.WriteLine("Bedankt om alle vragen te beantwoorden,)");
            Console.WriteLine("Uw visitekaartje wordt nu gegenereerd:");

            for (int i = 0; i < 6; i++)
            {
                Console.Write(gegevens[i] + " : ");
                Console.WriteLine(antwoorden[i]);
            }


            Console.WriteLine("Bedankt om gebruik te maken van dit programma!");

        }

    }
}
