using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Veiculo
    {
        private string tipo;
        private Hashtable partes = new Hashtable();

        public Veiculo(string tipo)
        {
            this.tipo = tipo;
        }

        // Indexador
        public object this[string chave]
        { 
            get { return partes[chave]; } 
            set { partes[chave] = value; } 
        } 

        public void Mostra()
        {    
            Console.WriteLine("\n---------------------------");    
            Console.WriteLine("Tipo do Veículo: {0}", tipo);
            Console.WriteLine(" Chassi : {0}", partes["chassi"]); 
            Console.WriteLine(" Motor : {0}", partes["motor"]); 
            Console.WriteLine(" #Rodas: {0}", partes["rodas"]); 
            Console.WriteLine(" #Portas : {0}", partes["portas"]);
        }
    }
}