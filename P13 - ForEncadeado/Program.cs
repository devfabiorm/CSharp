using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13___ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int countLine = 0; countLine < 10; countLine++)
            {
                for (int countColumn = 0; countColumn < 10; countColumn++)
                {
                    Console.Write("*");
                    if (countColumn >= countLine)
                        break;
                }
                Console.WriteLine();
            }

            for (int countLine = 0; countLine < 10; countLine++)
            {
                for (int countColumn = 0; countColumn <= countLine; countColumn++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
