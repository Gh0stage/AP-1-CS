using System;

namespace muziekMegalovania
{
    class Program
    {
        private static void Main(string[] args)
        {
            int width = 19;
            int height = 17;
            int xPixels = width * height;
            int[] drawing = new int[]
            {
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,1,1,1,1,1,1,1,1,1,0,0,0,0,0,
            0,0,0,1,1,0,0,0,0,0,0,0,0,0,1,1,0,0,0,
            0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,
            0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,
            0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,
            0,1,0,0,1,1,1,0,0,0,0,0,1,1,1,0,0,1,0,
            0,1,0,0,1,1,1,0,0,0,0,0,1,1,1,0,0,1,0,
            0,1,0,0,1,1,1,0,0,1,0,0,1,1,1,0,0,1,0,
            0,0,1,0,0,0,0,0,1,1,1,0,0,0,0,0,1,0,0,
            0,1,1,0,1,0,0,0,0,0,0,0,0,0,1,0,1,1,0,
            0,1,0,0,1,1,1,1,1,1,1,1,1,1,1,0,0,1,0,
            0,1,0,0,0,1,0,1,0,1,0,1,0,1,0,0,0,1,0,
            0,0,1,1,0,0,1,1,1,1,1,1,1,0,0,1,1,0,0,
            0,0,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,0,0,
            0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            };

            for (int Ycoord = 0; Ycoord < height; Ycoord++)
            {
                for (int Xcoord = 0; Xcoord < width; Xcoord++)
                {
                    int horizontalNumber = Ycoord * width + Xcoord;
                    switch (drawing[horizontalNumber])
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.White;
                            break;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Undertale - Megalovania");
            Console.WriteLine("to start the music, write play");
            Console.WriteLine("to stop the music, write quit");
            Boolean commandFulfilled = false;
            while (!commandFulfilled)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "play":
                        playTune();
                        break;
                    case "quit":
                        Environment.Exit(1);
                        commandFulfilled = true;
                        break;
                    default:
                        Console.WriteLine("write \"play\" or \"quit\"");
                        break;

                }
            }
        }
        public static void playTune()
        {
            const int pause = 0;
            const int duration = 300;
            const int A = 220;
            const int As = 233;
            const int B = 233;
            const int C = 130;
            const int D = 146;
            const int F = 174;
            const int G = 196;
            const int Gs = 207;

            Console.Beep(D, duration);
            Console.Beep(D, duration);
            Console.Beep(D, duration);
            Console.Beep(A, duration);
            Console.Beep(Gs, duration);
            Console.Beep(G, duration);
            Console.Beep(F, duration);
            Console.Beep(D, duration);
            Console.Beep(F, duration);
            Console.Beep(D, duration);

            Console.Beep(C, duration);
            Console.Beep(C, duration);
            Console.Beep(D, duration);
            Console.Beep(A, duration);
            Console.Beep(Gs, duration);
            Console.Beep(G, duration);
            Console.Beep(F, duration);
            Console.Beep(D, duration);
            Console.Beep(F, duration);
            Console.Beep(D, duration);

            Console.Beep(B, duration);
            Console.Beep(B, duration);
            Console.Beep(D, duration);
            Console.Beep(A, duration);
            Console.Beep(Gs, duration);
            Console.Beep(G, duration);
            Console.Beep(F, duration);
            Console.Beep(D, duration);
            Console.Beep(F, duration);
            Console.Beep(D, duration);

            Console.Beep(As, duration);
            Console.Beep(As, duration);
            Console.Beep(D, duration);
            Console.Beep(A, duration);
            Console.Beep(Gs, duration);
            Console.Beep(G, duration);
            Console.Beep(F, duration);
            Console.Beep(D, duration);
            Console.Beep(F, duration);
            Console.Beep(D, duration);
            Console.WriteLine("tune played");
            Console.WriteLine("PS. ik heb de muzieknoten van het internet, blame https://letter-notes.com/ voor de foute muzieknoten.");
        }
    }
}
