using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cond = 0;
            do {
                int[,] mat;
                Console.Write("Digite o numero linhas: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Digite o numero de colunas: ");
                int m = int.Parse(Console.ReadLine());

                mat = new int[n, m];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Digite a " + (i + 1) + "ª Linha");
                    string[] linha = Console.ReadLine().Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        mat[i, j] = int.Parse(linha[j]);
                    }
                }
                int a = 0, b = 0;
                Console.Write("Digite o numero que você quer encontrar: ");
                int op = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {


                    for (int j = 0; j < m; j++)
                    {
                        if (op == mat[i, j]) {
                            a = i;
                            b = j;
                        }
                    }
                }
                n -= 1;
                m -= 1;
                if (a > 0)
                    Console.WriteLine("Acima: " + mat[(a - 1), b]);
                if (a <= m - 1)
                    Console.WriteLine("Abaixo: " + mat[(a + 1), b]);
                if (b > 0)
                    Console.WriteLine("Esquerda: " + mat[a, (b - 1)]);
                if (b <= n - 1)
                    Console.WriteLine("Direita: " + mat[a, (b + 1)]);
                Console.WriteLine("0-SAIR."+"\n"+"1-Voltar");
                cond = int.Parse(Console.ReadLine());
            } while (cond==1);
        }
    }
}
