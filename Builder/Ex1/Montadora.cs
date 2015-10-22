using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /// <summary>
    /// Diretor
    /// </summary>
    class Montadora
    {
        public void Construir(ConstrutorVeiculo construtorVeiculo)
        {
            construtorVeiculo.ConstruirChassi();
            construtorVeiculo.ConstruirMotor();
            construtorVeiculo.ConstruirRodas();
            construtorVeiculo.ConstruirPortas();
        }
    }
}