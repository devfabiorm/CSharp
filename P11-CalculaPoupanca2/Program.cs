using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double appliedValue = 1000;

            for (int countMonth = 1; countMonth <= 12; countMonth++)
            {
                appliedValue *= 1.0036;
                Console.WriteLine("O rendimento após " + countMonth + "mês é R$" + appliedValue);
            }

            Console.ReadLine();
        }
    }
}
