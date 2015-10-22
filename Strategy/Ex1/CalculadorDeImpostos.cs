using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo1(Orcamento orcamento, string imposto)
        {
            #region Passo 1
            /*
            // Não sabemos qual é o imposto, então temos que verificar

            if ("ICMS".Equals(imposto)) // Invertida p/ resolver problema do valor nulo na variável
            {
                double icms = orcamento.Valor * 0.1; // 10%
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = orcamento.Valor * 0.06; // 6%
                Console.WriteLine(iss);
            }
            
             //...
             //vAlguns Problemas
             //  - Imagina se para cada imposto termos que aumentar um if ? Imagine 10 ou 15 impostos
             //  - Classe pouco coesa: Classe com muitas responsabilidades.            
            */
            #endregion

            #region Passo 2
            /*
            if ("ICMS".Equals(imposto))
            {
                // Nao precisamos colocar a regra de negócio aqui, porque ele já está implementada e encapsulada na outra classe...
                // Estamos delegando a responsabilidade para outra classe especializada e coesa
                
                double icms = new ICMS().CalculaICMS(orcamento); 
                Console.WriteLine(icms);
            }
            else if ("ISS".Equals(imposto))
            {
                double iss = new ISS().CalculaISS(orcamento); 
                Console.WriteLine(iss);
            }
            */
            //...
            // Alguns Problemas
            // Ainda o problema de termos muitos IFs
            
            #endregion
        }

        #region Passo 3

        // Tentando separar em métodos...
        /*
        public void RealizaCalculoICMS(Orcamento orcamento)
        {
            double icms = new ICMS().CalculaICMS(orcamento);
            Console.WriteLine(icms);
        }

        public void RealizaCalculoISS(Orcamento orcamento)
        {
            double iss = new ISS().CalculaISS(orcamento);
            Console.WriteLine(iss);
        }

        // O problema persiste
        // Ex.: Ao implementar outro imposto, um programador precisaria conhecer todo código
        */
        #endregion

        #region Passo 4

        // Com este método genérico por mais que se crie vários outros impostos não precisamos mexer no Calculador de Impostos

        public void RealizaCalculo(Orcamento orcamento, IImposto imposto) // Passar a interface como parâmetro
        {
            double resultado = imposto.Calcula(orcamento);

            Console.WriteLine(resultado);
        }

        #endregion
    }
}