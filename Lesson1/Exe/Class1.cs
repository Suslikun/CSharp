using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe
{
    class Les1
    {
        public void Print(string msg)
        {
            int x = Console.WindowWidth / 2 - msg.Length / 2;
            int y = Console.WindowHeight / 2;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        public double distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
