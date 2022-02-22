using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;
            double n4;
            double media;

            String nome;

            Console.Write("Insira o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write(" Insira o valor da nota1: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Insira o valor da nota2: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Insira o valor da nota3: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Insira o valor da nota4: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 9)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("O aluno " + nome + " tirou MB");
            }
            else if (media >= 8)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("O aluno " + nome + " tirou B");
                Console.ReadKey();
            }
            else if (media >= 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("O aluno " + nome + " tirou R");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O aluno " + nome + " tirou I");
            }
                Console.ReadKey();
            
        }
    }
}
