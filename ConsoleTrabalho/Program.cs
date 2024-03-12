using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota do aluno:");
            double nota = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a frequência do aluno:")
            int freq = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if nota >= 7 && freq >= 75)
                Console.WriteLine("O aluno está aprovado");
            else if (((nota < 7 && nota >= 4) && freq >= 75) || (nota >= 7 && freq < 75))
                Console.WriteLine("O aluno está retido");

            Console.ReadKey(); 
            }
        }
    }
}
