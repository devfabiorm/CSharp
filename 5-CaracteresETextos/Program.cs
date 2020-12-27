using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char firtChar = 'a';
            Console.WriteLine(firtChar);

            firtChar = (char)65;
            Console.WriteLine(firtChar);

            firtChar = (char)(firtChar + 1);
            Console.WriteLine(firtChar);

            string title = "Alura Cursos de Tecnologia " + 2020;
            string programmingCourses = @"- .NET
- Java
- JavaScript";

            Console.WriteLine(title);
            Console.WriteLine(programmingCourses);

            Console.ReadLine();
        }
    }
}
