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

            Console.WriteLine("Digite 0 para pares e 1 para impares: ");
            int opcao = int.Parse(Console.ReadLine());

            int cont = opcao;

            while (cont <= 20) 
            { 
            
            Console.WriteLine(cont);
                cont += 2;

            
            }

            Console.ReadKey();

        }
    }
}
