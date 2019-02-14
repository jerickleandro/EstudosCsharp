using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp3
{
    class Aluno
    {
        public string nome;
        public double nota1, nota2, nota3;

        public double notaFinal() {
            return nota1 + nota2 + nota3;
        }

        public string resultado() {
            if ((nota1 + nota2 + nota3) >= 60) {
                return "APROVADO";
            }
            else
            {
                double falta = 60.00 - notaFinal();
                return "REPROVADO"  + "\n" + "FALTARAM " + falta.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }


    }
}
