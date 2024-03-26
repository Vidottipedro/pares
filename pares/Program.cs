using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite par ou impar: ");
            string escolha = Console.ReadLine().ToLower();
            while (escolha != "par" && escolha != "impar")
            {
                Console.WriteLine("Digite par ou impar: ");
                escolha = Console.ReadLine().ToLower();
            }

            for (int i = 1; i <= 20; i++)
            {
                if (escolha == "par" && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (escolha == "impar" && i % 2 == 1)
                { 
                    Console.WriteLine(i);
                }
                Console.ReadKey();


            }
        }     
    }    
}
