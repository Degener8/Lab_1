using System;
using System.Collections.Generic;
using System.Text;

namespace fillwords
{
    class Field
    {
        static public int width, height;

        static void PrintRow(int times, string inp)
        {
            for (int i = 0; i < times; i++)
                Console.Write(inp);
        }

        static public void PrintField(char[,] letters)
        {
            Console.Write(new string('\n', (Console.WindowHeight - 1 - height * 2) / 2));

            for (int j = 0; j < height; j++)
            {
                if (j == 0)
                {
                    Console.Write($"{new string(' ', (Console.WindowWidth - 1 - width * 4) / 2)}╔");
                    PrintRow(width - 1, "═══╦");
                    Console.Write("═══╗\n");
                }
                else
                {
                    Console.Write($"{new string(' ', (Console.WindowWidth - 1 - width * 4) / 2)}╠");
                    PrintRow(width - 1, "═══╬");
                    Console.Write("═══╣\n");
                }


                for (int i = 0; i < width; i++)
                {
                    if (i == 0)
                        Console.Write($"{new string(' ', (Console.WindowWidth - 1 - width * 4) / 2)}║ {letters[j, i]} ║");
                    else Console.Write($" {letters[j, i]} ║");
                }

                Console.Write("\n");

                if (j == height - 1)
                {
                    Console.Write($"{new string(' ', (Console.WindowWidth - 1 - width * 4) / 2)}╚");
                    PrintRow(width - 1, "═══╩");
                    Console.Write("═══╝\n");
                }
            }

            Console.Write(new string('\n', (Console.WindowHeight - 1 - height * 2) / 2));

        }
        
    }
}
