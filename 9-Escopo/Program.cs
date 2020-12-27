using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais 2");

            int johnAge = 16;
            int peopleQuantity = 2;

            bool accompanied = peopleQuantity >= 2;
            string additionalMessage;

            if (accompanied == true)
            {
                additionalMessage = "João está acompanhado";
                //string additionalMessage = "João está acompanhado"; //Existe apenas dentro deste escopo
            }
            else
            {
                additionalMessage = "João não está acompanhado";
                //string additionalMessage = "João não está acompanhado"; //Existe apenas dentro deste escopo
            }

            if (johnAge >= 18 || accompanied == true)
            {
                Console.WriteLine("João pode entrar");
                Console.WriteLine(additionalMessage);
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
                Console.WriteLine(additionalMessage);
            }

            Console.ReadLine();
        }
    }
}
