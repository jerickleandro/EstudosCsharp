using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap10AbstractMethod.Entities;
using Cap10AbstractMethod.Entities.Enums;

namespace Cap10AbstractMethod {
    class Program {
        static void Main(string[] args) {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Shape #{(i + 1)} data:");
                Console.Write("Rectangule or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red) ");
                Color color;
                Enum.TryParse(Console.ReadLine(), true, out color);
                if (ch == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangle(width, height, color));
                } else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }

            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas: ");
            foreach (Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

        }
    }
}
