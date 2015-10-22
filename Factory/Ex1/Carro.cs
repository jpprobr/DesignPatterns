using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    /// <summary>
    /// Produto (Abstrato)
    /// </summary>
    public abstract class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }
    }
}