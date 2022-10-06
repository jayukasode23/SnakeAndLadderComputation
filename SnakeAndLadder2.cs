using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder2
    {
        public static void SnakeLadder()
        {
            int position = 0;

            Random random = new Random();

            Console.WriteLine("Player starts at position: " + position);

            int die = random.Next(1, 7);
            position += die;

            Console.WriteLine("Now at position " + position);
        }
    }
}
    