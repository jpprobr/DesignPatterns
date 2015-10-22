using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public abstract class FabricaMontadora
    {
        /// <summary>
        /// Definição do Factory Method p/ Criar Moto
        /// </summary>
        /// <returns></returns>
        public abstract Moto CriaMoto();
        
        /// <summary>
        /// Definição do Factory Method p/ Criar Carro
        /// </summary>
        /// <returns></returns>
        public abstract Carro CriaCarro();
    }
}
