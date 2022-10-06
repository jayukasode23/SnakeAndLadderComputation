using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder3
    {   
            //Constant
            public const int Noplay = 0;
            public const int Ladder = 1;
            public const int Snake = 2;



            public static void SnakeLadder()
            {
                int position = 100;

                Random random = new Random();

                Console.WriteLine("Player starts at position: " + position);

                int die = random.Next(1, 7);
                int option = random.Next(0, 3);

                switch (option)
                {
                    case Ladder:
                        position += die;
                        break;

                    case Snake:
                        position -= Snake;
                        break;

                    default:
                        position = position;
                        break;
                }
                Console.WriteLine(position);
            }

        }
    }


