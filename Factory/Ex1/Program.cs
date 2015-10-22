using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante[] fabricantes = new Fabricante[2];
            fabricantes[0] = new Volkswagen();
            fabricantes[1] = new Fiat();

            foreach (var fabricante in fabricantes)
            {
                Console.WriteLine("\n" + fabricante.GetType().Name + ":");


                foreach (Carro carro in fabricante.Carros)
                {
                    Console.WriteLine("\n - " + carro.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
