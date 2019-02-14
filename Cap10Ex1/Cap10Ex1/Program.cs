using System;
using System.Collections.Generic;
using System.Globalization;
using Cap10Ex1.Entities;

namespace Cap10Ex1 {
    class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++) {
                Console.WriteLine($"Employey #{(i+1)} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valuer Per Hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'y' || ch == 'Y') {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHours, additionalCharge));
                } else {
                    employees.Add(new Employee(name, hours, valuePerHours));
                }
                

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee emp in employees) {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

        }
    }
}
