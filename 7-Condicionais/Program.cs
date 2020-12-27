using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int johnAge = 16;
            int peopleQuantity = 2;

            if(johnAge >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar");
            }
            else
            {
                if(peopleQuantity >= 2)
                {
                    Console.WriteLine("João possui não possui mais de 18 anos, mas está acompalhado");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos. Não pode entrar.");
                }
                
            }

            Console.ReadLine();
        }
    }
}
