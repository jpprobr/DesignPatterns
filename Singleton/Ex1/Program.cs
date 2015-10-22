using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class ClasseA
    {
        public string MyProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo s/ Singleton
            ClasseA classe1 = new ClasseA();
            ClasseA classe2 = new ClasseA();
            classe1.MyProperty = "x";
            classe2.MyProperty = "y";
            
            Console.WriteLine("classe1.MyProperty = " + classe1.MyProperty);
            Console.WriteLine("classe2.MyProperty = " + classe2.MyProperty);
            Console.WriteLine();
            
            // Exemplo c/ Singleton
            Singleton singleton1 = Singleton.UniqueInstance;
            singleton1.MyProperty = "xxxxxx";
            Singleton singleton2 = Singleton.UniqueInstance;
            singleton2.MyProperty = "yyyyyy";

            Console.WriteLine("singleton1 = " + singleton1.MyProperty);
            Console.WriteLine("singleton2 = " + singleton2.MyProperty);
            
            Console.ReadKey();
        }
    }
}