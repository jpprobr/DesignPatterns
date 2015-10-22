using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    /// <summary>
    /// Subject
    /// </summary>
    public abstract class DistribuidoraAbstrata
    {
        public string Nome;
        protected double Preco;
        private ArrayList _postos = new ArrayList();

        /// <summary>
        /// Propriedade p/ ajustar e disparar notificação quando preço for alterado
        /// </summary>
        public double PrecoLitroGasolina
        {
            get { return Preco; }
            set
            {
                Preco = value;
                Notificar();
            }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="preco"></param>
        public DistribuidoraAbstrata(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        
        public void Anexar(IPosto posto)
        {
            _postos.Add(posto);
        }
       
        public void Desanexar(IPosto posto)
        {
            _postos.Remove(posto);
        }
       
        public void Notificar()
        {
            foreach (PostoDeGasolina posto in _postos)
            {
                posto.Atualizar(this);
            }

            Console.WriteLine("");
        }        
    }
}
