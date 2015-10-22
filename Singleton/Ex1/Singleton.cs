using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public sealed class Singleton
    {
        private static Singleton _uniqueInstance;

        public static Singleton UniqueInstance
        {
            get
            {
                if (_uniqueInstance == null)
                {
                    _uniqueInstance = new Singleton();
                    Console.WriteLine("\n Instancia Criada!");
                }

                return _uniqueInstance;
            }
        }


        /// <summary>
        /// Exemplo de Propriedade para a Classe Singleton
        /// </summary>
        public string MyProperty { get; set; }


        private Singleton() { }
    }
}