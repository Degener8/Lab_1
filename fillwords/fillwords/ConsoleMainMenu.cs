﻿using System;
using System.Collections.Generic;
using System.Text;

namespace fillwords
{
    class ConsoleMainMenu
    {
        static string[] positions = { "Новая игра", "Продолжить игру", "Рейтинг", "Выход" };

        static int flag = 0;


        public static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine(new String('\n', Console.WindowHeight / 8));

            for (int i = 0; i < positions.Length; i++)
            {
                if (flag == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{new String(' ', (Console.WindowWidth - positions[i].Length) / 2)}{ positions[i]} \n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.WriteLine($"{new String(' ', (Console.WindowWidth - positions[i].Length) / 2)}{ positions[i]} \n\n");
            }
        }

        static void CheckPosition(ConsoleKey pressed)
        {
            if (flag == 0 && pressed == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine(new String('\n', Console.WindowHeight / 4));
                Console.Write($"{new String(' ', (Console.WindowWidth - 17) / 2)}Введите ваше имя: ");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (flag == 1 && pressed == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine(new String('\n', Console.WindowHeight / 4));
                Console.Write($"{new String(' ', (Console.WindowWidth - 41) / 2)}Когда-нибудь здесь будет продолжение игры.");
                Environment.Exit(0);
            }
            else if (flag == 2 && pressed == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine(new String('\n', Console.WindowHeight / 4));
                Console.Write($"{new String(' ', (Console.WindowWidth - 40) / 2)}Когда-нибудь здесь будет рейтинг игроков.");
                Environment.Exit(0);
            }
            else if (pressed == ConsoleKey.Enter && flag == 3)
                Environment.Exit(0);
        }
        
        public static void SelectPosition()
        {
            ConsoleKey pressed;
            do
            {
                pressed = Console.ReadKey().Key;
               
                if (pressed == ConsoleKey.W || pressed == ConsoleKey.UpArrow)
                    flag = (flag + 3) % positions.Length;
                else if (pressed == ConsoleKey.S || pressed == ConsoleKey.DownArrow)
                    flag = (flag + 1) % positions.Length;

                CheckPosition(pressed);
                
                PrintMenu();
            }
            while (true);
        }

    }
}