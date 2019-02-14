using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;
            double areaX, areaY , p;


            X = new Triangulo();
            Y = new Triangulo();
            Console.Write("Digite o lado a do triangulo X: ");
            X.a = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Digite o lado b do triangulo X: ");
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o lado c do triangulo X: ");
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o lado a do triangulo y: ");
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o lado b do triangulo y: ");
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o lado c do triangulo y: ");
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            p = (X.a + X.b + X.c) / 2;
            areaX = Math.Sqrt(p * (p - X.a) * (p - X.b) * (p - X.c));

            p = (Y.a + Y.b + Y.c) / 2;
            areaY = Math.Sqrt(p * (p - Y.a) * (p - Y.b) * (p - Y.c));


            Console.WriteLine("Área do triangulo X " + areaX);
            Console.WriteLine("Área do triangulo Y " + areaY);
            Console.ReadLine();
        }
    }
}
