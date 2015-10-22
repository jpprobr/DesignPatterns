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
            // Cria montadora com construtores de veículos    
            Montadora montadora = new Montadora();
            ConstrutorVeiculo c1 = new ConstrutorMoto();
            ConstrutorVeiculo c2 = new ConstrutorCarro();

            // Construir and display veiculos     
            montadora.Construir(c1);
            c1.Veiculo.Mostra();

            montadora.Construir(c2);
            c2.Veiculo.Mostra();

            Console.ReadKey();
        }
    }
}