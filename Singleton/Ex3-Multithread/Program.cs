using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex3_Multithread
{
    class Program
    {
        static Singleton s1;
        static Singleton s2;

        static void Main(string[] args)
        {

            // Simulando o uso do Singleton
            s1 = Singleton.UniqueInstance;
            s1.MyProperty = "x";

            // Atualiza valor da instancia
            Console.WriteLine("Valor de s1 = " + s1.MyProperty);
            
            // Acessando de outra Thread
            Thread t2 = new Thread(new ThreadStart(TestaSingletonThread));
            t2.Start();

            Console.ReadKey();
        }

        public static void TestaSingletonThread()
        {
            // Cria instancia em outra Thread
            s2 = Singleton.UniqueInstance;

            // Atualiza valor da instancia
            s2.MyProperty = "y";
                        
            Console.WriteLine("Valor da s2 = " + s2.MyProperty);
            Console.WriteLine();
            Console.WriteLine("Novo Valor de s1 = " + s1.MyProperty);
        }
    }
}
