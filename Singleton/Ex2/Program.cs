using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadeira cadeira1 = Cadeira.UniqueInstance;
            cadeira1.Quantidade = 1;

            Cadeira cadeira2 = Cadeira.UniqueInstance;
            cadeira2.Quantidade = 3;

            Console.WriteLine("cadeira1.Quantidade = " + cadeira1.Quantidade);
            Console.WriteLine("cadeira2.Quantidade = " + cadeira2.Quantidade);

            Console.ReadKey();
        }
    }
}
