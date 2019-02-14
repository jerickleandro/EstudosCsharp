using System;
using System.Collections.Generic;
using System.Globalization;
using Cap10Heranca.Entities;

namespace Cap10Heranca {
    class Program {
        static void Main(string[] args) {
            /*
             * Exemplos Genericos
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);
            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.00100);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount) {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if(acc3 is SavingsAccount) {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

            Account acc6 = new Account(1006, "Alex", 500.0);
            Account acc7 = new SavingsAccount(1007, "Anna", 500.0, 0.01 );

            acc6.WithDraw(10.00);
            acc7.WithDraw(10.00);

            Console.WriteLine(acc6.Balance);
            Console.WriteLine(acc7.Balance);


            Console.ReadLine();
            */
            //Classe Abstrata
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double soma = 0.0;
            foreach(Account acc in list) {
                soma += acc.Balance;
            }
            Console.WriteLine("Total balance: "+soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
