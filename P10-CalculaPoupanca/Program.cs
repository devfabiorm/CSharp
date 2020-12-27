using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

            double appliedValue = 1000;
            int countMonth = 1;

            while (countMonth <= 12)
            {
                appliedValue = appliedValue + appliedValue * 0.0036;
                Console.WriteLine("Após " + countMonth + " mês, você terá R$" + appliedValue);

                countMonth++;
            }


            Console.ReadLine();
        }
    }
}
