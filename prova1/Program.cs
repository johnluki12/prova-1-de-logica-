using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova1
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // joão lucas lopes de souza : ra 6322004
            double nt, n1, n2, media;
            string nome;
            Console.WriteLine(" Informe o nome do aluno:");
            nome = Console.ReadLine();
            Console.WriteLine(" Informe a nota de trabalho :");
            nt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Informe a nota da primeira prova :");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Informe a nota da segunda prova :");
            n2 = Convert.ToDouble(Console.ReadLine());
            media = (nt + n1 + n2) / 3;
            if (media < 0 || media > 10)
            {
                Console.WriteLine(" Erro tente novamente");
            }
            else if (media >= 8.5)
            {
                Console.WriteLine("O aluno " + nome + " teve uma media de " + media + " então o conceito é A. ");
            }
            else if (media <= 8.4 && media >= 7.0)
            {
                Console.WriteLine("O aluno " + nome + " teve uma media de " + media + " então o conceito é B. ");
            }
            else if (media <= 6.9 && media >= 6.0)
            {
                Console.WriteLine("O aluno " + nome + " teve uma media de " + media + " então o conceito é C. ");
            }
            else if (media <= 5.9 && media >= 0.1)
            {
                Console.WriteLine("O aluno " + nome + " teve uma media de " + media + " então o conceito é D. ");
            }
            else
            {
                Console.WriteLine("O aluno " + nome + " teve uma media de " + media + " então o conceito é E. ");
            }
            Console.ReadKey();
        }
    }
}
