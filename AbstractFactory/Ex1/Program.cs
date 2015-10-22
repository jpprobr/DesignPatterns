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
            // Cria a Fábrica da Honda com seus respectivos automóveis
            FabricaHonda honda = new FabricaHonda();
            Automoveis auto = new Automoveis(honda);

            // Cria a Fábrica da Suzuki com seus respectivos automóveis
            FabricaHonda suzuki = new FabricaHonda();
            auto = new Automoveis(suzuki);
        }
    }
}