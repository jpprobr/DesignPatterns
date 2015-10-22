using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    /// <summary>
    /// Criadores concretos
    /// </summary>
    public class Volkswagen : Fabricante
    {
        /// <summary>
        /// Implementação do Método Fábrica (Factory Method)
        /// </summary>
        public override void CriaCarros()
        {
            Carros.Add(new Idea());
            Carros.Add(new Marea());
        }
    }
}