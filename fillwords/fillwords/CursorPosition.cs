using System;
using System.Collections.Generic;
using System.Text;

namespace fillwords
{
    class CursorPosition
    {
        static public int x = 0;
        static public int y = 0;

        static public ConsoleKey pressed;

        static public int SelectPosition(int nX)
        {
            pressed = Console.ReadKey().Key;

            if (pressed == ConsoleKey.W || pressed == ConsoleKey.UpArrow)
                x = (x + 3) % nX;
            else if (pressed == ConsoleKey.S || pressed == ConsoleKey.DownArrow)
                x = (x + 1) % nX;

            return x;
        }

        static public void SelectPosition(int nX,int nY)
        {
            pressed = Console.ReadKey().Key;

            if (pressed == ConsoleKey.W || pressed == ConsoleKey.UpArrow)
                y = (y + 3) % nY;
            else if (pressed == ConsoleKey.S || pressed == ConsoleKey.DownArrow)
                y = (y + 1) % nY;

            if (pressed == ConsoleKey.W || pressed == ConsoleKey.UpArrow)
                x = (x + 3) % nX;
            else if (pressed == ConsoleKey.S || pressed == ConsoleKey.DownArrow)
                x = (x + 1) % nX;

            
        }

    }
}
