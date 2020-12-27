using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int age = 32;
            int gustavAge = age;

            age = 20;

            Console.WriteLine(age);
            Console.WriteLine(gustavAge);

            Console.ReadLine();
        }
    }
}
