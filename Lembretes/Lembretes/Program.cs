using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lembretes {
    class Program {
        [DllImport("Kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        static void Main(string[] args) {



            int minuto = 0;
            string continuar;
            Console.WriteLine("Daqui a quantos minutos você quer ser lembrado para berber água?");
            minuto = int.Parse(Console.ReadLine());
            do {
                IntPtr hWnd = GetConsoleWindow();
                ShowWindow(hWnd, 0);
                DateTime d1 = DateTime.Now;
                DateTime d2 = d1.AddMinutes(minuto);
                do {
                    d1 = DateTime.Now;
                } while (d1.Minute < d2.Minute);

                Console.WriteLine("Beber Água");
                ShowWindow(hWnd, 1);
                Console.WriteLine("Deseja Continuar? S/N");

                continuar = Console.ReadLine();
            } while (continuar == "s" || continuar == "S");

        }
    }
}
