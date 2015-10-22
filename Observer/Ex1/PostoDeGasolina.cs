using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /// <summary>
    /// Observador Concreto
    /// </summary>
    public class PostoDeGasolina : IPosto
    {
        private string _nome;
        public Distribuidora distribuidora;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        public PostoDeGasolina(string nome)
        {
            this._nome = nome;
        }

        public void Atualizar(DistribuidoraAbstrata distribuidora)
        {
            Console.WriteLine("{0} notificado pela {1} a mudar o preco para {2:C}", this._nome, distribuidora.Nome, distribuidora.PrecoLitroGasolina);
        }
    }
}