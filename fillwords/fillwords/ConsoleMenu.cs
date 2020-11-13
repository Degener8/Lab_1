using System;
using System.Collections.Generic;
using System.Text;

namespace fillwords
{
    class ConsoleMenu
    {
        static public string[] positions = { "Новая игра", "Продолжить игру", "Рейтинг", "Выход" };

        static public void PrintTitle()
        {
            Console.WriteLine(new String('\n', Console.WindowHeight / 10));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("______   _   _   _                                 _\n"
            + "|  ___| (_) | | | |                               | | \n"
            + "| |_     _  | | | | __      __   ___    _ __    __| |  ___ \n"
            + "|  _|   | | | | | | \\ \\ /\\ / /  / _ \\  | '__|  / _` | / __| \n"
            + "| |     | | | | | |  \\ V  V /  | (_) | | |    | (_| | \\__ \\ \n"
            + "\\_|     |_| |_| |_|   \\_/\\_/    \\___/  |_|     \\__,_| |___/");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static public void PrintMenu(int x)
        {
            Console.Clear();
            PrintTitle();
            
            for(int i = 0; i <positions.Length; i++)
            {
                if(i == x)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{new String('\n',Console.WindowHeight / 8)}" +
                        $"{new String(' ', (Console.WindowWidth - positions[i].Length) / 2)}" +
                        $"{positions[i]}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    Console.WriteLine($"{new String('\n', Console.WindowHeight / 8)}" +
                        $"{new String(' ', (Console.WindowWidth - positions[i].Length) / 2)}" +
                        $"{positions[i]}");
            }
        }
        
        static void LaunchNewGame()
        {
            Console.Clear();
            Console.Write("Введите ваше имя: ");
            Console.ReadLine();
            Environment.Exit(0);
        }


        static public void CheckPosition(int x, ConsoleKey pressed)
        {
            if (x == 0 && pressed == ConsoleKey.Enter)
                LaunchNewGame();
            else if (x == 1 && pressed == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine($"{new String('\n', Console.WindowHeight / 8)}" +
                    $"{new String(' ', (Console.WindowWidth - 39) / 2)}" +
                    "Когда-нибудь вы сможете продолжить игру.");
                Environment.Exit(0);
            }
            else if (x == 2 && pressed == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine($"{new String('\n', Console.WindowHeight / 8)}" +
                    $"{new String(' ', (Console.WindowWidth - 43) / 2)}" +
                    "Когда-нибудь тут будет рейтинговая таблица.");
                Environment.Exit(0);
            }
            else if (x == 3 && pressed == ConsoleKey.Enter)
                Environment.Exit(0);
        }
    }
}
