using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    public abstract class Fabricante
    {
        /// <summary>
        /// Field _carros (acesso privado)
        /// </summary>
        private List<Carro> _carros = new List<Carro>();

        /// <summary>
        /// Propriedade Carros
        /// </summary>
        public  List<Carro> Carros
        {
            // Acesso somente leitura
            get { return _carros; }
        }


        /// <summary>
        /// Construtor chama o método Fábrica (factory Method)
        /// </summary>
        public Fabricante()
        {
            // Chama método Factory
            this.CriaCarros();
        }

        /// <summary>
        /// Factory Method
        /// </summary>
        public abstract void CriaCarros();
    }
}
