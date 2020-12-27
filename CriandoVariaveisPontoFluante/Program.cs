using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveisPontoFluante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variáveis ponto fluante");

            double salary;
            salary = 1200.70;

            Console.WriteLine(salary);

            double age;
            age = 15.0 / 2;

            Console.WriteLine(age);

            age = 5 / 3;

            Console.WriteLine("5 / 3 = " + age);

            age = 5.0 / 3;

            Console.WriteLine("5.0 / 3 = " + age);

            Console.WriteLine("A execução terminou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
