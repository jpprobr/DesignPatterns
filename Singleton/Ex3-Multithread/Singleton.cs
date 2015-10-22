using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_Multithread
{
    public sealed class Singleton
    {        
        // Volatile garante que várias threads lidem com a variável corretamente / garante que a atribuição para a variável seja concluída antes da variável poder ser acessada
        private static volatile Singleton _uniqueInstance;
        private static object _syncRoot = new Object();

        public static Singleton UniqueInstance
        {
            get
            {
                if (_uniqueInstance == null)
                {
                    // lock garante que o bloco seja concluído sem interrupção por outros threads
                    lock (_syncRoot) 
                    {
                        if (_uniqueInstance == null)
                        {
                            _uniqueInstance = new Singleton();
                            Console.WriteLine("\n Instancia Criada!");    
                        }
                    }
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