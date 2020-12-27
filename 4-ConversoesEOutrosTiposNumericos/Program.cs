using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salary;
            salary = 1200.50;

            int integerSalary; //32 bits
            integerSalary = (int)salary;

            Console.WriteLine(integerSalary);

            long age; //64 bits
            age = 13000000000;

            Console.WriteLine(age);

            short productsQuantity; // 16 bits
            productsQuantity = 15000;

            Console.WriteLine(productsQuantity);

            float height = 1.80f;

            Console.WriteLine(height);

            Console.ReadLine();
        }
    }
}
