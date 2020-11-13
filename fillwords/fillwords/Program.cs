using System;
using System.Collections.Generic;

namespace fillwords
{
    class Program
    {
        static string[] positions = { "Новая игра", "Продолжить игру", "Рейтинг", "Выход" };



        static void Main(string[] args)
        {
            ConsoleMenu.PrintMenu(CursorPosition.x);


            do
            {
                CursorPosition.SelectPosition(positions.Length);
                ConsoleMenu.PrintMenu(CursorPosition.x);

                ConsoleMenu.CheckPosition(CursorPosition.x, CursorPosition.pressed);
            }
            while (true);
        }
    }
}
