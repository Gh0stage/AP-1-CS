using System;

namespace simpleMaths
{
    class calculator
    {
        static void Main(string[] args)
        {
            double answer = 0;
            string input = "";

            Console.WriteLine("Je kan hiermee optellen, vermenigvuldigen, delen en de modulo berekenen");
            Console.WriteLine("gelieve tussen elk getal en elk symbool een spatie te zetten, vb:");
            Console.WriteLine("4 * 3 + 2 - 16.5 % 3");
            Console.WriteLine("(je kan de rekenmachine op elk moment afsluiten door \"quit\" in te geven)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            input = Console.ReadLine();
            answer = Calculate(input);
            Console.WriteLine(answer);
            Environment.Exit(1);
        }

        private static Double Calculate(string input)
        {
            if(input.Length == 4)
            {
                if (input.Substring(0, 4).Equals("quit") || input.Substring(0, 4).Equals("exit"))
                {
                    return 0;
                }
            }
            if (input.IndexOf("*") != -1)
            {
                Calculate(input.Substring(0, input.IndexOf("*")), input.Substring(input.IndexOf("*") + 1, input.Length), '*');     
            }
            else if (input.IndexOf("/") != -1)
            {
                Calculate(input.Substring(0, input.IndexOf("/")), input.Substring(input.IndexOf("/") + 1), '/');
            }
            else if (input.IndexOf("%") != -1)
            {
                Calculate(input.Substring(0, input.IndexOf("%")), input.Substring(input.IndexOf("%") + 1), '%');
            }
            else if (input.IndexOf("-") != -1)
            {
                Calculate(input.Substring(0, input.IndexOf("-")), input.Substring(input.IndexOf("-") + 1), '-');
            }
            else if (input.IndexOf("+") != -1)
            {
                Calculate(input.Substring(0, input.IndexOf("+")), input.Substring(input.IndexOf("+") + 1), '+');
            }
            else
            {
                return Convert.ToDouble(input);
            }


        }
        
        private static double Calculate(string leftInput, string rightInput, char modifier)
        {
           double partA =  Calculate(leftInput);
           double partB =  Calculate(rightInput);
            if (modifier.Equals("*"))
            {
                return partA* partB;
            }
            else if (modifier.Equals("/"))
            {
                return partA / partB;
            } else if (modifier.Equals("%"))
            {
                return partA % partB;
            } else if (modifier.Equals("+"))
            {
                return partA + partB;
            } else if (modifier.Equals("-"))
            {
                return partA - partB;
            }
            else
            {
                Console.WriteLine("Er is een fout in functie private static double Calculate(string leftInput, string rightInput, char modifier)");
                return 0;
            }
        }
    }
}
