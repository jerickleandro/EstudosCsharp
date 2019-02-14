using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            do
            {
                Console.Write("Nota 1: ");
                a.nota1 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (a.nota1 > 30 || a.nota1 < 0)
                {
                    Console.WriteLine("Para esse trimestre somente notas de 0 até 30.00");
                }
            } while (a.nota1 > 30 || a.nota1 < 0);
            do
            {
                Console.Write("Nota 2: ");
                a.nota2 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (a.nota2 > 35 || a.nota2 < 0)
                {
                    Console.WriteLine("Para esse trimestre somente notas de 0 até 35.00");
                }
            } while (a.nota2 > 35 || a.nota2 < 0);
            do
            {
                Console.Write("Nota 3: ");
                a.nota3 = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (a.nota3 > 35 || a.nota3 < 0)
                {
                    Console.WriteLine("Para esse trimestre somente notas de 0 até 35.00");
                }
            } while (a.nota3 > 35 || a.nota3 < 0);
            Console.WriteLine("NOTA FINAL = " + a.notaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(a.resultado());
            Console.ReadLine();
        }
    }
}
