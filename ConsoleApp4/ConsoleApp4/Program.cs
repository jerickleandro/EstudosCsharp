using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            if (dia == 22) {
                Console.WriteLine("Se consegue ver isso é pq o dia é 22");
            }
            Console.ReadLine();

        }
    }
}
