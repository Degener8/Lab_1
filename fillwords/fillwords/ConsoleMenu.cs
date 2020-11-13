using System;
using System.Collections.Generic;
using System.Text;

namespace fillwords
{
    class ConsoleMenu
    {
        static void PrintTitle()
        {
            Console.WriteLine(new String('\n', Console.WindowHeight / 10));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("______   _   _   _                                 _\n"
            + "|  ___| (_) | | | |                               | | \n"
            + "| |_     _  | | | | __      __   ___    _ __    __| |  ___ \n"
            + "|  _|   | | | | | | \\ \\ /\\ / /  / _ \\  | '__|  / _` | / __| \n"
            + "| |     | | | | | |  \\ V  V /  | (_) | | |    | (_| | \\__ \\ \n"
            + "\\_|     |_| |_| |_|   \\_/\\_/    \\___/  |_|     \\__,_| |___/");
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        static void CheckPosition(ConsoleKey pressed, int x)
        {
            if (x == 0 && pressed == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine(new String('\n', Console.WindowHeight / 4));
                Console.Write($"{new String(' ', (Console.WindowWidth - 17) / 2)}Введите ваше имя: ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (x == 1 && pressed == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine(new String('\n', Console.WindowHeight / 4));
                Console.Write($"{new String(' ', (Console.WindowWidth - 41) / 2)}Когда-нибудь здесь будет продолжение игры.");
                Environment.Exit(0);
            }
            else if (x == 2 && pressed == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine(new String('\n', Console.WindowHeight / 4));
                Console.Write($"{new String(' ', (Console.WindowWidth - 40) / 2)}Когда-нибудь здесь будет рейтинг игроков.");
                Environment.Exit(0);
            }
            else if (pressed == ConsoleKey.Enter && x == 3)
                Environment.Exit(0);
        }



    }
}
