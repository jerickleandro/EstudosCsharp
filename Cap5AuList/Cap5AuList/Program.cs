using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5AuList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Erick");
            list.Add("Lima");
            list.Insert(2, "Pedro Pedigree");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Quantidade de cadastros: "+list.Count);
            Console.WriteLine("------------------------------------");
            string s1 = list.Find(x => x[0] == 'E');
            string s2 = list.FindLast(x => x[0] == 'L');
            int pos1 = list.FindIndex(x => x[0] == 'E');
            int pos2 = list.FindLastIndex(x => x[0] == 'L');
            Console.WriteLine("------------------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------");
            list.Remove("Lima");
             Console.WriteLine("------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("------------------------------------");
            list.RemoveAt(1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
