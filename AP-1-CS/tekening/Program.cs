using System;

namespace tekeningMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 10;
            int height = 12;
            int xPixels = width * height;
            int[] drawing = new int[]
            {   
            0, 0, 0, 3, 3, 3, 0, 0, 0, 0,
            0, 0, 3, 3, 3, 3, 3, 3, 3, 0,
            0, 3, 3, 3, 1, 1, 3, 1, 0, 0,
            3, 3, 1, 3, 3, 1, 1, 1, 1, 0,
            3, 3, 1, 1, 1, 1, 3, 3, 1, 0,
            0, 0, 1, 1, 1, 1, 1, 1, 0, 0,
            0, 3, 3, 2, 3, 3, 2, 0, 0, 0,
            3, 3, 3, 2, 3, 3, 2, 3, 3, 0,
            1, 1, 3, 0, 2, 2, 0, 3, 3, 1,
            1, 1, 2, 2, 2, 2, 2, 2, 1, 1,
            0, 0, 3, 3, 0, 0, 3, 3, 0, 0,
            0, 3, 3, 3, 0, 0, 3, 3, 3, 0
            };

            for (int Ycoord = 0; Ycoord < height; Ycoord++)
            {
                for(int Xcoord = 0; Xcoord < width; Xcoord++)
                {
                    int horizontalNumber = Ycoord * width + Xcoord;
                    switch (drawing[horizontalNumber])
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.White;
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Mario 8bit");

        }
    }
}
