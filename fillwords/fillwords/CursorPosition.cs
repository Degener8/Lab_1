using System;
using System.Collections.Generic;
using System.Text;

namespace fillwords
{
        
        public static void SelectPosition(ConsoleKey pressed, int nPos, out int x, out int y)
        {
            
            pressed = Console.ReadKey().Key;

            if (pressed == ConsoleKey.W || pressed == ConsoleKey.UpArrow)
                x = (x + 3) % nPos;
            else if (pressed == ConsoleKey.S || pressed == ConsoleKey.DownArrow)
                x = (x + 1) % nPos;
        }

    }
}
