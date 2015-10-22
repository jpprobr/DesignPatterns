using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Distribuidora : DistribuidoraAbstrata
    {
        /// <summary>
        /// Sujeito (Subject) Concreto
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="preco"></param>
        public Distribuidora(string nome, double preco) : base(nome, preco)
        {
            
        }
    }
}