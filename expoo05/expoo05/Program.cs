using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expoo05
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos Aluguéis serão registrados? ");
            int n = int.Parse(Console.ReadLine());
            Quartos[] vet = new Quartos[10];

            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine("Dados do " + i + "º Aluguel:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int qt = int.Parse(Console.ReadLine());
                vet[qt] = new Quartos(nome, email);
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(vet[i]);
                }
            }
            Console.ReadLine();

        }
    }
}
