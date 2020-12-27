using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double appliedValue = 1000;
            double incomeFactor = 1.0036;

            for (int countYear = 1; countYear <= 5; countYear++)
            {
                for(int countMonth =1; countMonth <= 12; countMonth++)
                {
                    appliedValue *= incomeFactor;
                }
                incomeFactor += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$" + appliedValue);

            Console.ReadLine();
        }
    }
}
