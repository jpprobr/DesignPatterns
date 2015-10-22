using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    public class Fiat : Fabricante
    {
        /// <summary>
        /// Implementação do Método Fábrica (Factory Method)
        /// </summary>
        public override void CriaCarros()
        {
            Carros.Add(new Golf());
            Carros.Add(new Polo());
        }
    }
}
